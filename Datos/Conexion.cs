using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BBDD_ConexionBD.Datos
{
    internal class Conexion
    {
        //utilizamos esta conexion en otras clases
        protected SqlConnection bd = new SqlConnection("Data Source=ASUS-TUF505DV\\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;");

        public bool conectar()
        {
            try  //Capturador de errores por si ocurro una ecepxion
            { 
                bd.Open();

                if (bd.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void desconectar()
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
