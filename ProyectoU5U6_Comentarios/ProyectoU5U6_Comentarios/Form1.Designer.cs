
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
            this.LayoutComent = new System.Windows.Forms.TableLayoutPanel();
            this.pPubliComent = new System.Windows.Forms.Panel();
            this.btpubli = new System.Windows.Forms.Button();
            this.rtxtb_publi = new System.Windows.Forms.RichTextBox();
            this.lbpubli = new System.Windows.Forms.Label();
            this.LayoutComent.SuspendLayout();
            this.pPubliComent.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutComent
            // 
            this.LayoutComent.AutoScroll = true;
            this.LayoutComent.ColumnCount = 1;
            this.LayoutComent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutComent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutComent.Controls.Add(this.pPubliComent, 0, 1);
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
            // pPubliComent
            // 
            this.pPubliComent.Controls.Add(this.btpubli);
            this.pPubliComent.Controls.Add(this.rtxtb_publi);
            this.pPubliComent.Controls.Add(this.lbpubli);
            this.pPubliComent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPubliComent.Location = new System.Drawing.Point(3, 185);
            this.pPubliComent.Name = "pPubliComent";
            this.pPubliComent.Size = new System.Drawing.Size(1075, 162);
            this.pPubliComent.TabIndex = 7;
            this.pPubliComent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btpubli
            // 
            this.btpubli.Location = new System.Drawing.Point(837, 120);
            this.btpubli.Name = "btpubli";
            this.btpubli.Size = new System.Drawing.Size(75, 29);
            this.btpubli.TabIndex = 2;
            this.btpubli.Text = "Publicar";
            this.btpubli.UseVisualStyleBackColor = true;
            this.btpubli.Click += new System.EventHandler(this.btpubli_Click);
            // 
            // rtxtb_publi
            // 
            this.rtxtb_publi.Location = new System.Drawing.Point(7, 23);
            this.rtxtb_publi.Name = "rtxtb_publi";
            this.rtxtb_publi.Size = new System.Drawing.Size(905, 91);
            this.rtxtb_publi.TabIndex = 1;
            this.rtxtb_publi.Text = "";
            // 
            // lbpubli
            // 
            this.lbpubli.AutoSize = true;
            this.lbpubli.Location = new System.Drawing.Point(3, 0);
            this.lbpubli.Name = "lbpubli";
            this.lbpubli.Size = new System.Drawing.Size(110, 20);
            this.lbpubli.TabIndex = 0;
            this.lbpubli.Text = "Antonio Sanchez";
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
            this.pPubliComent.ResumeLayout(false);
            this.pPubliComent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel LayoutComent;
        private System.Windows.Forms.Panel pPubliComent;
        private System.Windows.Forms.Button btpubli;
        private System.Windows.Forms.RichTextBox rtxtb_publi;
        private System.Windows.Forms.Label lbpubli;
    }
}

