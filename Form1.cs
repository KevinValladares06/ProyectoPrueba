using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//importante agregar 
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BBDD_ConexionBD
{
    public partial class Form1 : Form

    {
        //Data Source=ASUS-TUF505DV\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;Encrypt=True;Trust Server Certificate=True (se borraron algunos)
        private SqlConnection conexion = new SqlConnection("Data Source=ASUS-TUF505DV\\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                
                if (conexion.State == ConnectionState.Open)//verificamos que la conexion este abierta 
                {
                    MessageBox.Show("La conexion ha sido exitosa");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.Close(); //al terminar cerramos la conexion 
            }
           

        }
    }
}
