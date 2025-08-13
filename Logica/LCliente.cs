﻿using BBDD_ConexionBD.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDD_ConexionBD.Logica
{
    internal class LCliente //realiza validaciones
    {
        public void crear(string nom,string ape,string nid,string dire,string tel)
        {
            try
            {
                DCliente dc = new DCliente(nom,ape,nid,dire,tel);

                    if (dc.existeCliente() == false)
                    {
                        if (dc.crear() == true)
                        {
                         MessageBox.Show("Cliente Creado Correctamente");
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DCliente getDatosCliente(string numId)
        {
            try
            {
                DCliente dc = new DCliente();
                dc.NUM_ID= numId;
                return dc.getDatosCliente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public void Actualizar(int idC, string nom, string ape, string nid, string dire, string tel, string cal)
        {

            try
            {
                DCliente dc = new DCliente(nom, ape, nid, dire, tel, cal);

                dc.ID = idC;

                if (dc.existeCliente() == true)
                {
                    if (dc.Actualizar() == true)
                    {
                        MessageBox.Show("Cliente se ha actualizado Correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void Eliminar(int idC)
        {

            try
            {
                DCliente dc = new DCliente();

                dc.ID = idC;

                if (dc.existeCliente() == true)
                {
                    if (dc.Eliminar() == true)
                    {
                        MessageBox.Show("Cliente se ha eliminado Correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
