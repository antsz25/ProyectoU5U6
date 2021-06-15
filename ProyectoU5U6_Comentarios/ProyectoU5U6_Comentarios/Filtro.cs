using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoU5U6_Comentarios
{
    public static class Filtro
    {
        public static Dictionary<string, string> filtro = new Dictionary<string, string>();
        public static int Contador = 0;

        public static bool ChecarComentario(RichTextBox texto)
        {
            for (int i = 0; i <= filtro.Count - 1; i++)
            {
                if (texto.Text.ToLower().Contains(filtro[i.ToString()]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ChecarComentario(string texto)
        {
            for (int i = 0; i <= filtro.Count - 1; i++)
            {
                if (texto.ToLower().Contains(filtro[i.ToString()].ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public static void AñadirMalaPalabra(string palabra)
        {
            StreamWriter textOut = null;
            try
            {
                filtro.Add(Contador++.ToString(), palabra.ToLower());
                textOut = new StreamWriter(new FileStream(Application.StartupPath + @"\DB\Filtro.txt", FileMode.Open, FileAccess.Write));
                List<string> words = LeerFiltro(Application.StartupPath + @"\DB\Filtro.txt");
                foreach (var c in words)
                {
                    textOut.WriteLine(c);
                }
                textOut.WriteLine(palabra);
                textOut.Close();
                MessageBox.Show("Palabra añadida con exito");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Error en el formato del filtro" + e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al guardar la palabra" + e.Message);
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }
        static List<string> LeerFiltro(string path)
        {
            List<string> words = new List<string>();
            try
            {
                if (File.Exists(path))
                {
                    StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                    while (textIn.Peek() != -1)    // Leer hasta el final
                    {
                        string row = textIn.ReadLine();  // row =  "1000|Prueba|13/Junio/2021|198.192.0.1|Esto es una prueba|3|0"
                        string c = row;
                        words.Add(c);
                    }

                    textIn.Close();

                    return words;
                }
                else
                {

                    StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Create));
                    textIn.Close();
                    return words;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return words;
        }
        public static void CargarDiccionario(string path)
        {
            StreamReader charge = null;
            try
            {
                if (File.Exists(path))
                {
                    charge = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                    /// Palabra1
                    /// Palabra2
                    while (charge.Peek() != -1)    // Leer hasta el final
                    {
                        string row = charge.ReadLine();
                        filtro.Add(Contador++.ToString(), row);
                    }
                    charge.Close();
                }
                else
                {
                    File.Create(path);
                }
            }
            catch(IOException e)
            {
                MessageBox.Show("Error al cargar filtro" + e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al cargar filtro" + e.Message);
            }
            finally
            {
                if (charge != null)
                    charge.Close();
            }
        }

    }
}
