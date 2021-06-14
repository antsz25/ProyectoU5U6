using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
            AgregarComentarios(Reescribe());
        }
        private List<Comentario> Reescribe()
        {
            List<Comentario> comments = ComentariosDB.ReadFromFile(Application.StartupPath + @"/DB/Comentarios.txt");
            List<Comentario> inapropiate = ComentariosDB.ReadFromFile(Application.StartupPath + @"/DB/ComentariosInapropiados.txt");
            for (int i = 0; i <= comments.Count - 1; i++)
            {
                for (int j = 0; j <= inapropiate.Count - 1; j++)
                {
                    comments.RemoveAll(x => x.id == inapropiate[j].id);
                }
            }
            comments.Sort();
            comments.Reverse();
            return comments;
        }
        private void AgregarComentarios(List<Comentario> comments)
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
        class Comentario : IComparable
        {
            public int id { get; set; }
            public string autor { get; set; }
            public string fecha_publi { get; set; }
            public string comentario { get; set; }
            public string dir_ip { get; set; }
            public int likes { get; set; }
            public int inapropiado { get; set; }

            public int CompareTo(object obj)
            {
                return this.id.CompareTo((obj as Comentario).id);
            }

            public override string ToString()
            {
                return string.Format($"{id},{autor},{fecha_publi},{comentario},{dir_ip},{inapropiado},{likes}");
            }
            public Comentario()
            {

            }

            public Comentario(int id, string autor, string fecha_publi, string comentario, string dir_ip, int likes, int inapropiado)
            {
                this.id = id;
                this.autor = autor;
                this.fecha_publi = fecha_publi;
                this.comentario = comentario;
                this.dir_ip = dir_ip;
                this.likes = likes;
                this.inapropiado = inapropiado;
            }
        }
        class ComentariosDB
        {
            public static void SaveToFile(Comentario comment, string path)
            {
                StreamWriter textOut = null;

                try
                {
                    if (File.Exists(path)) {
                        List<Comentario> comments = ComentariosDB.ReadFromFile(Application.StartupPath + @"/DB/Comentarios.txt");
                        textOut = new StreamWriter(new FileStream(path, FileMode.Open, FileAccess.Write));
                        // row =  "1000|Prueba|13/Junio/2021|198.192.0.1|Esto es una prueba|3|0"
                        foreach(var c in comments)
                        {
                            textOut.Write(c.id + "|");
                            textOut.Write(c.autor + "|");
                            textOut.Write(c.fecha_publi + "|");
                            textOut.Write(c.dir_ip + "|");
                            textOut.Write(c.comentario + "|");
                            textOut.Write(c.likes + "|");
                            textOut.WriteLine(c.inapropiado);
                        }
                        textOut.Write(comment.id + "|");
                        textOut.Write(comment.autor + "|");
                        textOut.Write(comment.fecha_publi + "|");
                        textOut.Write(comment.dir_ip + "|");
                        textOut.Write(comment.comentario + "|");
                        textOut.Write(comment.likes + "|");
                        textOut.WriteLine(comment.inapropiado);
                        textOut.Close();

                    }
                    else
                    {
                        textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
                        // row =  "1000|Prueba|13/Junio/2021|198.192.0.1|Esto es una prueba|3|0"
                        textOut.Write(comment.id + "|");
                        textOut.Write(comment.autor + "|");
                        textOut.Write(comment.fecha_publi + "|");
                        textOut.Write(comment.dir_ip + "|");
                        textOut.Write(comment.comentario + "|");
                        textOut.Write(comment.likes + "|");
                        textOut.WriteLine(comment.inapropiado);
                        textOut.Close();
                    }


                }

                catch (IOException)
                {
                    Console.WriteLine("Ya existe el archivo");
                }

                catch (Exception)
                {
                    Console.WriteLine("Error");
                }

                finally
                {
                    if (textOut != null)
                        textOut.Close();
                }


            }
            public static List<Comentario> ReadFromFile(string path)
            {
                List<Comentario> comments = new List<Comentario>();
                try
                {
                    if (File.Exists(path)) {
                        StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                        while (textIn.Peek() != -1)    // Leer hasta el final
                        {
                                string row = textIn.ReadLine();  // row =  "1000|Prueba|13/Junio/2021|198.192.0.1|Esto es una prueba|3|0"
                                string[] columns = row.Split('|'); // ["1000","Prueba","13/Junio/2021","Esto es una prueba","3","0"]; 
                                Comentario c = new Comentario();
                                c.id = int.Parse(columns[0]);
                                c.autor = columns[1];
                                c.fecha_publi = columns[2];
                                c.dir_ip = columns[3];
                                c.comentario = columns[4];
                                c.likes = int.Parse(columns[5]);
                                c.inapropiado = int.Parse(columns[6]);
                                comments.Add(c);
                        }

                        textIn.Close();

                        return comments;
                    }
                    else
                    {

                        StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Create));
                        textIn.Close();

                        return comments;
                    }
                }
                catch(IOException e)
                {
                    MessageBox.Show(e.ToString());
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                return comments;
            }
            public static int GetLastID(string path)
            {
                try
                {
                    List<Comentario> comments = ReadFromFile(path);


                    var filtro_productos = from c in comments
                                           select c;
                    return filtro_productos.Last().id;
                }
                catch(Exception e)
                {
                    Console.WriteLine("No hay comentarios registrados. Se define como el primer commentario en 1000");
                    return 999;
                }
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
            string date = DateTime.Today.ToShortDateString();
            int last = ComentariosDB.GetLastID(Application.StartupPath + @"/DB/Comentarios.txt");
            Comentario c = new Comentario(last + 1, lbpubli.Text,date, rtxtb_publi.Text, "198.192.0.0", 0, 0);
            ComentariosDB.SaveToFile(c, Application.StartupPath + @"/DB/Comentarios.txt");
            // List<Comentario> comments = ComentariosDB.ReadFromFile(Application.StartupPath + @"/DB/Comentarios.txt");


            /*for (int i = 0; i <= LayoutComent.RowCount - 1; i++)
            {
                Control a = LayoutComent.GetControlFromPosition(0,i);
                rtxtb_publi.Text += a.Name + "\n";
            }*/
            this.Controls.Clear();
            this.InitializeComponent();
            this.AgregarComentarios(Reescribe());
        }
    }
}
