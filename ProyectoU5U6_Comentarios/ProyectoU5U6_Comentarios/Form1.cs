using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU5U6_Comentarios
{

    public partial class Form1 : Form
    {
        private Label lbinapropi;
        private Label lbfechai;
        private Label lbautori;
        private Panel pComment2;
        private RichTextBox rtxtb_commenti;
        private Button bt_respi;
        private Label lblikesi;
        private Button bt_likei;
        
        public Form1()
        {
            InitializeComponent();
            Filtro.CargarDiccionario(Application.StartupPath + @"\DB\Filtro.txt");
            AgregarComentarios(Reescribe());
        }
        private List<Comentario> Reescribe()
        {
            List<Comentario> comments = null;
            List<Comentario> inapropiate = null;
            try
            {
                comments = ComentariosDB.ReadFromFile(Application.StartupPath + @"\DB\Comentarios.txt");
                inapropiate = ComentariosDB.ReadFromFile(Application.StartupPath + @"\DB\ComentariosInapropiados.txt");
                if (inapropiate[0] ==null)
                {
                    inapropiate.RemoveAt(0);
                    for (int i = 0; i <= comments.Count - 1; i++)
                    {
                        if (Filtro.ChecarComentario(comments[i].comentario))
                        {
                            inapropiate.Add(comments[i]);
                        }
                    }
                    ComentariosDB.SaveToFile(inapropiate, Application.StartupPath + @"\DB\ComentariosInapropiados.txt", true);
                }
                for (int i = 0; i <= comments.Count - 1; i++)
                {

                    for (int j = 0; j <= inapropiate.Count - 1; j++)
                    {
                        if (Filtro.ChecarComentario(comments[i].comentario) && comments[i].id != inapropiate[j].id)
                        {
                            inapropiate.Add(comments[i]);
                        }
                        comments.RemoveAll(x => x.id == inapropiate[j].id);
                    }
                }
                inapropiate.Sort();
                inapropiate.Reverse();
                ComentariosDB.SaveToFile(inapropiate, Application.StartupPath + @"\DB\ComentariosInapropiados.txt", true);
                comments.Sort();
                comments.Reverse();
                return comments;
            }
            catch(ArgumentNullException e)
            {
                MessageBox.Show("Error al cargar comentarios: "+e);
                return comments;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al cargar comentarios: " + e);
                return comments;
            }
        }
        private void PublicarComentario()
        {
            if (Filtro.ChecarComentario(rtxtb_publi)) //Checa que no contenga ninguna mala palabra
            {
                string date = DateTime.Today.ToShortDateString(); //Se obtiene la fecha de publicacion
                int last = ComentariosDB.GetLastID(Application.StartupPath + @"\DB\Comentarios.txt"); //Consigue el ultimo comentario publicado
                Comentario c = new Comentario(last + 1, lbpubli.Text, date, rtxtb_publi.Text, "198.192.0.0", 0, 0);//Se define el comentario
                ComentariosDB.SaveToFile(c, Application.StartupPath + @"\DB\Comentarios.txt", false);//Guardado en archivo
                ComentariosDB.SaveToFile(c, Application.StartupPath + @"\DB\ComentariosInapropiados.txt",true); //Guardado en archivo
                MessageBox.Show("Tu mensaje no pudo ser publicado debido a que contiene palabras obscenas.");
            }
            else
            {
                string date = DateTime.Today.ToShortDateString();//Se obtiene la fecha de publicacion
                int last = ComentariosDB.GetLastID(Application.StartupPath + @"\DB\Comentarios.txt");//Consigue el ultimo comentario publicado
                Comentario c = new Comentario(last + 1, lbpubli.Text, date, rtxtb_publi.Text, "198.192.0.0", 0, 0);//Se define el comentario
                ComentariosDB.SaveToFile(c, Application.StartupPath + @"\DB\Comentarios.txt",false);//Guardado en archivo
                //Se reinicia la forma para cargar los nuevos comentarios
                this.Controls.Clear(); 
                this.InitializeComponent(); 
                this.AgregarComentarios(Reescribe());
            }
        }
        private void AgregarComentarios(List<Comentario> comments)
        {
            try
            {

                foreach (var comment in comments)
                {
                    // 
                    // lbautori
                    // 
                    lbautori = new Label();
                    this.lbautori.AutoSize = true;
                    this.lbautori.BackColor = System.Drawing.Color.Transparent;
                    this.lbautori.Location = new System.Drawing.Point(4, 2);
                    this.lbautori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                    this.lbautori.Name = "lbautor" + comment.id;
                    this.lbautori.Size = new System.Drawing.Size(40, 20);
                    this.lbautori.TabIndex = 3;
                    this.lbautori.Text = comment.autor;
                    // 
                    // bt_likei
                    // 
                    bt_likei = new Button();
                    this.bt_likei.Location = new System.Drawing.Point(8, 69);
                    this.bt_likei.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                    this.bt_likei.Name = "bt_like" + comment.id;
                    this.bt_likei.Size = new System.Drawing.Size(81, 28);
                    this.bt_likei.TabIndex = 0;
                    this.bt_likei.Text = "Me gusta";
                    this.bt_likei.UseVisualStyleBackColor = true;
                    this.bt_likei.Click += new System.EventHandler(this.button1_Click);
                    // 
                    // bt_respi
                    // 
                    bt_respi = new Button();
                    this.bt_respi.Location = new System.Drawing.Point(97, 69);
                    this.bt_respi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                    this.bt_respi.Name = "bt_resp" + comment.id;
                    this.bt_respi.Size = new System.Drawing.Size(87, 28);
                    this.bt_respi.TabIndex = 1;
                    this.bt_respi.Text = "Responder";
                    this.bt_respi.UseVisualStyleBackColor = true;
                    this.bt_respi.Click += new System.EventHandler(this.button2_Click);
                    // 
                    // lblikesi
                    // 
                    lblikesi = new Label();
                    this.lblikesi.AutoSize = true;
                    this.lblikesi.BackColor = System.Drawing.Color.Transparent;
                    this.lblikesi.Location = new System.Drawing.Point(198, 74);
                    this.lblikesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                    this.lblikesi.Name = "lblikes" + comment.id;
                    this.lblikesi.Size = new System.Drawing.Size(41, 20);
                    this.lblikesi.TabIndex = 5;
                    this.lblikesi.Text = "Likes: " + comment.likes;
                    // 
                    // rtxtb_commenti
                    // 
                    rtxtb_commenti = new RichTextBox();
                    this.rtxtb_commenti.BackColor = System.Drawing.SystemColors.ControlLightLight;
                    this.rtxtb_commenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.rtxtb_commenti.Location = new System.Drawing.Point(8, 25);
                    this.rtxtb_commenti.Name = "rtxtb_comment" + comment.id;
                    this.rtxtb_commenti.ReadOnly = true;
                    this.rtxtb_commenti.Size = new System.Drawing.Size(905, 41);
                    this.rtxtb_commenti.TabIndex = 2;
                    this.rtxtb_commenti.Text = comment.comentario;
                    this.rtxtb_commenti.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
                    // 
                    // lbfechai
                    // 
                    lbfechai = new Label();
                    this.lbfechai.AutoSize = true;
                    this.lbfechai.BackColor = System.Drawing.Color.Transparent;
                    this.lbfechai.Location = new System.Drawing.Point(649, 2);
                    this.lbfechai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                    this.lbfechai.Name = "lbfecha" + comment.id;
                    this.lbfechai.Size = new System.Drawing.Size(46, 20);
                    this.lbfechai.TabIndex = 6;
                    this.lbfechai.Text = "Fecha: " + comment.fecha_publi;
                    // 
                    // lbinapropi
                    // 
                    lbinapropi = new Label();
                    this.lbinapropi.AutoSize = true;
                    this.lbinapropi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.lbinapropi.ForeColor = System.Drawing.Color.Blue;
                    this.lbinapropi.Location = new System.Drawing.Point(760, 74);
                    this.lbinapropi.Name = "lbinaprop" + comment.id;
                    this.lbinapropi.Size = new System.Drawing.Size(153, 15);
                    this.lbinapropi.TabIndex = 7;
                    this.lbinapropi.Text = "Marcar como inapropiado";
                    // 
                    // pCommenti
                    // 
                    pComment2 = new Panel();
                    this.pComment2.AutoScroll = true;
                    this.pComment2.Controls.Add(this.lbinapropi);
                    this.pComment2.Controls.Add(this.lbfechai);
                    this.pComment2.Controls.Add(this.lbautori);
                    this.pComment2.Controls.Add(this.rtxtb_commenti);
                    this.pComment2.Controls.Add(this.bt_respi);
                    this.pComment2.Controls.Add(this.lblikesi);
                    this.pComment2.Controls.Add(this.bt_likei);
                    this.pComment2.Dock = System.Windows.Forms.DockStyle.Top;
                    this.pComment2.Location = new System.Drawing.Point(2, 3);
                    this.pComment2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
                    this.pComment2.Name = "pComment" + comment.id;
                    this.pComment2.Size = new System.Drawing.Size(917, 104);
                    this.pComment2.TabIndex = 6;
                    LayoutComent.Controls.Add(pComment2, 0, 0);
                }
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("Error al mostrar comentario: "+e);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al mostrar comentario: "+e);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LayoutComent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btpubli_Click(object sender, EventArgs e)
        {
            PublicarComentario();//Publica el comentario
        }

        private void btAddFiltro_Click(object sender, EventArgs e)
        {
            Filtro.AñadirMalaPalabra(txtBFiltro.Text);//Agregar malas palabras al diccionario   
            txtBFiltro.Clear();//Limpia el texto
        }
    }
}
