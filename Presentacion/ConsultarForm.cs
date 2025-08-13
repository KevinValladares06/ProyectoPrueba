using BBDD_ConexionBD.Datos;
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
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LCliente lc=new LCliente();
            try
            {
                DCliente dcte = lc.getDatosCliente(txtIdentificacionCliente.Text);
                if (dcte == null) // No se encontró el cliente
                {
                    MessageBox.Show("No existe un cliente con el número de identificación ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                txtIdCliente.Text = dcte.ID.ToString();
                txtNombreCliente.Text = dcte.NOMBRES;
                txtApellidosCliente.Text = dcte.APELLIDOS;
                txtDireccionCliente.Text = dcte.DIRECCION;
                txtTelefonoCliente.Text = dcte.TELEFONO;
                txtCalificacionCliente.Text = dcte.CALIFICACION;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear objeto con los datos del formulario
                LCliente lc = new LCliente();

                lc.Actualizar(
                    int.Parse(txtIdCliente.Text),        // idC
                    txtNombreCliente.Text,               // nom
                    txtApellidosCliente.Text,             // ape
                    txtIdentificacionCliente.Text,        // nid (NUM_ID)
                    txtDireccionCliente.Text,             // dire
                    txtTelefonoCliente.Text,              // tel
                    txtCalificacionCliente.Text
                ); 
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
