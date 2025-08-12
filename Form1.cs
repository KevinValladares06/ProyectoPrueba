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
using BBDD_ConexionBD.Presentacion;


namespace BBDD_ConexionBD
{
    public partial class Form1 : Form

    {
        //Data Source=ASUS-TUF505DV\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True;Encrypt=True;Trust Server Certificate=True (se borraron algunos)

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClienteForm formCrearCliente = new ClienteForm(); //construimos y mandamos a llamar el formulario 
            this.Hide();


            formCrearCliente.Show();

            
        }
    }
}
