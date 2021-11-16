using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Cache;
using Negocio;

namespace TF_Grupo1.Presentacion.Admin
{
    public partial class frmPanelAdministrador : Form
    {
        public frmPanelAdministrador()
        {
            InitializeComponent();
            cmbTipo.SelectedIndex=0;
        }
        eUsuario objuser = new eUsuario();
        usuarioModel NegocioUser = new usuarioModel();
        
        
        string Operacion = "Insertar";
        string idUsuario;
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cmbTipo.SelectedIndex != 0)
            {
                if (Operacion == "Insertar")
                {
                    objuser.Codigo = Convert.ToInt32(txtCodigo.Text);
                    objuser.Contraseña = txtContraseña.Text;
                    objuser.Tipo = cmbTipo.SelectedIndex;
                    objuser.Nombre=txtNombre.Text;
                    objuser.ApellidoPaterno=txtApellidoPaterno.Text;
                    objuser.ApellidoMaterno=txtApellidoMaterno.Text;
                    objuser.Dni=txtDni.Text;
                    objuser.NumeroCelular=txtNumeroCelular.Text;
                    NegocioUser.CrearUsuario(objuser);
                }
            else if (Operacion == "Editar")
            {

            }
           
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de usuario");
            }
        }
    }
}
