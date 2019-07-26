using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Examen_IA
{
    public partial class Guardar_Identidad : Form
    {
        public static int ancho = 0;
        public static int alto = 0;
        public static int[,] arr_r;
        public static int[,] arr_g;
        public static int[,] arr_b;
        Bitmap imagen;
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=identidad; Uid=root; port=3306; pwd=Misael_0801198109176;");
       
        public Guardar_Identidad()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        
        private void pblImage_DoubleClick(object sender, EventArgs e)
        {
            ofd.Filter = "Archivo de Imagen |*.jpg|Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pblimagen.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            if (txtnombre.Text == "" || txtnumero.Text == "")
            {
                MessageBox.Show("Ningun Campo debe estar vacio", "Error");
            }
            else
            {
                if (pblimagen.Image == null)
                {
                    MessageBox.Show("Haga doble click en el Cuadro de Imagen para ingresar una imagen", "Error");
                }
                else
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("insert into tbl_identidades(Numero, Nombre, Foto) values('" + Convert.ToInt64(txtnumero.Text.Trim()) + "','" + txtnombre.Text.Trim() + "',@Imagen)", con);
                        MemoryStream ms = new MemoryStream();
                        pblimagen.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] aByte = ms.ToArray();
                        cmd.Parameters.AddWithValue("Imagen", aByte);
                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Datos Guardados Correctamente", "Guardar");
                            txtnombre.Text = "";
                            txtnumero.Text = "";
                            pblimagen.Image = null;          
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
             con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Archivo de Imagen |*.jpg|Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pblimagen.Image = Image.FromFile(ofd.FileName);
            }  
        }
    }
}
