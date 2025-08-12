using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDD_ConexionBD.Datos
{
    internal class DCliente:Conexion //agregando la clase conexion 
    {
        private int id; //agregamos campos de tabla tienda.clientes
        private string nombres;
        private string apellidos;
        private string numId;
        private string direccion;
        private string telefono;
        //private string calificacion;

        private SqlCommand cmd; //objeto que nos permite ejecutar procedimeintos crud


        //Constructor

        public DCliente(string nombres, string apellidos, string numId, string direccion, string telefono)
        {
            //this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numId = numId;
            this.direccion = direccion;
            this.telefono = telefono;
            //this.calificacion = calificacion;
        }

        public int ID
        {
            get { return id; }

            set { id = value; }
        }

        public string NOMBRES
        {
            get { return nombres; }

            set { nombres = value; }
        }
        public string APELLIDOS
        {
            get { return apellidos; }

            set { apellidos = value; }
        }
        public string NUM_ID
        {
            get { return numId; }

            set { numId = value; }
        }
        public string DIRECCION
        {
            get { return direccion; }

            set { direccion = value; }
        }
        public string TELEFONO
        {
            get { return telefono; }

            set { telefono = value; }
        }

        /*
        public string CALIFICACION
        {
            get { return calificacion; }

            set { calificacion = value; }
        }*/


        //metodo para insertar registro
        public bool crear()
        {

            try
            {
                conectar();

                cmd = new SqlCommand("INSERT INTO tienda.clientes(NOMBRES,APELLIDOS,DIRECCION,TELEFONO,CALIFICACION,NUM_ID)" +
                "VALUES('" + nombres + "','" + apellidos + "','" + direccion + "','" + telefono + "','A','" + numId + "')"); //argumetno del constructor

                cmd.Connection = bd;

                if (cmd.ExecuteNonQuery() > 0)
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
            finally
            {
                desconectar(); //si se interrumpe la conexion con la base de datos 
            }


            
            
        }

        public bool existeCliente()
        {
            try
            {
                conectar();

                string consulta = "SELECT COUNT(*) FROM tienda.clientes WHERE NUM_ID = @numId";
                cmd = new SqlCommand(consulta, bd);
                cmd.Parameters.AddWithValue("@numId", numId);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar existencia del cliente: " + ex.Message);
                return false;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
