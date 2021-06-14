
namespace ProyectoU5U6_Comentarios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbautor1 = new System.Windows.Forms.Label();
            this.LayoutComent = new System.Windows.Forms.TableLayoutPanel();
            this.pComment1 = new System.Windows.Forms.Panel();
            this.bt_like1 = new System.Windows.Forms.Button();
            this.bt_resp1 = new System.Windows.Forms.Button();
            this.lblikes1 = new System.Windows.Forms.Label();
            this.rtxtb_comment1 = new System.Windows.Forms.RichTextBox();
            this.lbfecha1 = new System.Windows.Forms.Label();
            this.lbinaprop1 = new System.Windows.Forms.Label();
            this.lbpubli = new System.Windows.Forms.Label();
            this.rtxtb_publi = new System.Windows.Forms.RichTextBox();
            this.btpubli = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LayoutComent.SuspendLayout();
            this.pComment1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbautor1
            // 
            this.lbautor1.AutoSize = true;
            this.lbautor1.BackColor = System.Drawing.Color.Transparent;
            this.lbautor1.Location = new System.Drawing.Point(4, 2);
            this.lbautor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbautor1.Name = "lbautor1";
            this.lbautor1.Size = new System.Drawing.Size(40, 20);
            this.lbautor1.TabIndex = 3;
            this.lbautor1.Text = "Autor";
            // 
            // LayoutComent
            // 
            this.LayoutComent.ColumnCount = 2;
            this.LayoutComent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutComent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutComent.Controls.Add(this.pComment1, 0, 0);
            this.LayoutComent.Controls.Add(this.panel2, 0, 1);
            this.LayoutComent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutComent.Location = new System.Drawing.Point(0, 12);
            this.LayoutComent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LayoutComent.Name = "LayoutComent";
            this.LayoutComent.RowCount = 2;
            this.LayoutComent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutComent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutComent.Size = new System.Drawing.Size(1081, 350);
            this.LayoutComent.TabIndex = 0;
            this.LayoutComent.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutComent_Paint);
            // 
            // pComment1
            // 
            this.pComment1.AutoScroll = true;
            this.pComment1.Controls.Add(this.lbinaprop1);
            this.pComment1.Controls.Add(this.lbfecha1);
            this.pComment1.Controls.Add(this.lbautor1);
            this.pComment1.Controls.Add(this.rtxtb_comment1);
            this.pComment1.Controls.Add(this.bt_resp1);
            this.pComment1.Controls.Add(this.lblikes1);
            this.pComment1.Controls.Add(this.bt_like1);
            this.pComment1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pComment1.Location = new System.Drawing.Point(2, 3);
            this.pComment1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pComment1.Name = "pComment1";
            this.pComment1.Size = new System.Drawing.Size(917, 104);
            this.pComment1.TabIndex = 6;
            // 
            // bt_like1
            // 
            this.bt_like1.Location = new System.Drawing.Point(8, 69);
            this.bt_like1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_like1.Name = "bt_like1";
            this.bt_like1.Size = new System.Drawing.Size(81, 28);
            this.bt_like1.TabIndex = 0;
            this.bt_like1.Text = "Me gusta";
            this.bt_like1.UseVisualStyleBackColor = true;
            this.bt_like1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_resp1
            // 
            this.bt_resp1.Location = new System.Drawing.Point(97, 69);
            this.bt_resp1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_resp1.Name = "bt_resp1";
            this.bt_resp1.Size = new System.Drawing.Size(87, 28);
            this.bt_resp1.TabIndex = 1;
            this.bt_resp1.Text = "Responder";
            this.bt_resp1.UseVisualStyleBackColor = true;
            this.bt_resp1.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblikes1
            // 
            this.lblikes1.AutoSize = true;
            this.lblikes1.BackColor = System.Drawing.Color.Transparent;
            this.lblikes1.Location = new System.Drawing.Point(198, 74);
            this.lblikes1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblikes1.Name = "lblikes1";
            this.lblikes1.Size = new System.Drawing.Size(41, 20);
            this.lblikes1.TabIndex = 5;
            this.lblikes1.Text = "Likes";
            this.lblikes1.Click += new System.EventHandler(this.lblikes1_Click);
            // 
            // rtxtb_comment1
            // 
            this.rtxtb_comment1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtxtb_comment1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtb_comment1.Location = new System.Drawing.Point(8, 25);
            this.rtxtb_comment1.Name = "rtxtb_comment1";
            this.rtxtb_comment1.ReadOnly = true;
            this.rtxtb_comment1.Size = new System.Drawing.Size(905, 41);
            this.rtxtb_comment1.TabIndex = 2;
            this.rtxtb_comment1.Text = "fffffffff\nfffff\nfff";
            this.rtxtb_comment1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbfecha1
            // 
            this.lbfecha1.AutoSize = true;
            this.lbfecha1.BackColor = System.Drawing.Color.Transparent;
            this.lbfecha1.Location = new System.Drawing.Point(649, 2);
            this.lbfecha1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfecha1.Name = "lbfecha1";
            this.lbfecha1.Size = new System.Drawing.Size(46, 20);
            this.lbfecha1.TabIndex = 6;
            this.lbfecha1.Text = "Fecha";
            // 
            // lbinaprop1
            // 
            this.lbinaprop1.AutoSize = true;
            this.lbinaprop1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinaprop1.ForeColor = System.Drawing.Color.Blue;
            this.lbinaprop1.Location = new System.Drawing.Point(760, 74);
            this.lbinaprop1.Name = "lbinaprop1";
            this.lbinaprop1.Size = new System.Drawing.Size(153, 15);
            this.lbinaprop1.TabIndex = 7;
            this.lbinaprop1.Text = "Marcar como inapropiado";
            // 
            // lbpubli
            // 
            this.lbpubli.AutoSize = true;
            this.lbpubli.Location = new System.Drawing.Point(3, 0);
            this.lbpubli.Name = "lbpubli";
            this.lbpubli.Size = new System.Drawing.Size(93, 20);
            this.lbpubli.TabIndex = 0;
            this.lbpubli.Text = "Nombre_publi";
            // 
            // rtxtb_publi
            // 
            this.rtxtb_publi.Location = new System.Drawing.Point(7, 23);
            this.rtxtb_publi.Name = "rtxtb_publi";
            this.rtxtb_publi.Size = new System.Drawing.Size(905, 91);
            this.rtxtb_publi.TabIndex = 1;
            this.rtxtb_publi.Text = "";
            // 
            // btpubli
            // 
            this.btpubli.Location = new System.Drawing.Point(837, 120);
            this.btpubli.Name = "btpubli";
            this.btpubli.Size = new System.Drawing.Size(75, 29);
            this.btpubli.TabIndex = 2;
            this.btpubli.Text = "Publicar";
            this.btpubli.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btpubli);
            this.panel2.Controls.Add(this.rtxtb_publi);
            this.panel2.Controls.Add(this.lbpubli);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 155);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1081, 362);
            this.Controls.Add(this.LayoutComent);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LayoutComent.ResumeLayout(false);
            this.pComment1.ResumeLayout(false);
            this.pComment1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbautor1;
        private System.Windows.Forms.TableLayoutPanel LayoutComent;
        private System.Windows.Forms.Panel pComment1;
        private System.Windows.Forms.Button bt_resp1;
        private System.Windows.Forms.Button bt_like1;
        private System.Windows.Forms.Label lblikes1;
        private System.Windows.Forms.RichTextBox rtxtb_comment1;
        private System.Windows.Forms.Label lbfecha1;
        private System.Windows.Forms.Label lbinaprop1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btpubli;
        private System.Windows.Forms.RichTextBox rtxtb_publi;
        private System.Windows.Forms.Label lbpubli;
    }
}

