
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace Examen_IA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=identidad; Uid=root; port=3306; pwd=Misael_0801198109176;");

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbImagen(object sender, EventArgs e)
        {

        }

        private void pbImagenn_DoubleClick(object sender, EventArgs e)
        {
            ofb.Filter = "Archivo de Imagen |*.jpg|Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofb.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbImagenn.Image = Image.FromFile(ofb.FileName);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar_Identidad m = new Guardar_Identidad();
            m.Visible = true;
        }

        private void pbImagenn_Click(object sender, EventArgs e)
        {

        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            ofb.Filter = "Archivo de Imagen |*.jpg|Archivo PNG|*.png|Todos los Archivos|*.*";
            DialogResult resultado = ofb.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                pbImagenn.Image = Image.FromFile(ofb.FileName);
            }
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            if (pbImagenn.Image == null)
            {
                MessageBox.Show("No ha cargado ninguna imagen", "Error");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbImagenn.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                Comparar(aByte);
            }

        }


        private void Comparar(byte[] Entrada)
        {

            byte[] alm = null;
            bool flag;
            int canFotos = 0;

            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=identidad; Uid=root; port=3306; pwd=Misael_0801198109176;");

            con.Open();
            MySqlCommand contar = new MySqlCommand("SELECT count(*) FROM tbl_identidades;", con);
            object result = contar.ExecuteScalar();
            if (result != null)
            {
                canFotos = Convert.ToInt32(result);
            }
            con.Close();

            for (int q = 1; q <= canFotos; q++)
            {
                flag = true;
                con.Open();
                string query = "SELECT Foto FROM tbl_identidades WHERE CodigoID = " + q;
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader leer = cmd.ExecuteReader();
                try
                {
                    while (leer.Read())
                    {
                        alm = (byte[])leer["Foto"];
                    }
                }
                finally
                {
                    leer.Close();
                }
                con.Close();

                if (alm.Length == Entrada.Length)
                {
                    for (int i = 0; i < alm.Length; i++)
                    {
                        if (alm[i] != Entrada[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }

                if (flag)
                {
                    MessageBox.Show("Los patrones de las imagenes son iguales", "Mensaje");
                    break;
                }
                else
                {
                    if (q >= canFotos)
                    {
                        MessageBox.Show("Los patrones de las imagenes son distintos", "Mensaje");
                        pbImagenn.Image = null;
                    }
                }
            }
        }

    }
}
