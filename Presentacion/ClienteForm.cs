using BBDD_ConexionBD.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDD_ConexionBD.Presentacion
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                LCliente lc = new LCliente();

                //mandamos a llamar al metodo crear
                lc.crear(txtNombres.Text,txtApellidos.Text,txtId.Text,txtDireccion.Text,txtTelefono.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
