using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU5U6_Comentarios
{
    public partial class MalasPalabras : Form
    {
        public MalasPalabras()
        {
            InitializeComponent();
        }

        private void MalasPalabras_Load(object sender, EventArgs e)
        {
            try
            {

                foreach (var filter in Filtro.filtro)
                {
                    richTextBox1.Text += filter.Key + "," + filter.Value + "\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Filtro.AñadirMalaPalabra(textBox1.Text);
                this.Controls.Clear();
                InitializeComponent();
                foreach (var filter in Filtro.filtro)
                {
                    richTextBox1.Text += filter.Key + "," + filter.Value + "\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MalasPalabras_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
