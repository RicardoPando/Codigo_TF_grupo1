using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades.Cache;
using TF_Grupo1.Presentacion.Gestor;
using TF_Grupo1.Presentacion.EmpleadoVenta;
using TF_Grupo1.Presentacion.Admin;

namespace TF_Grupo1.Presentacion.Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                        if (txtContraseña.Text != "")
                        {
                            usuarioModel user = new usuarioModel();
                            var validLogin = user.LoginUsuario(Convert.ToInt32(txtUsuario.Text), txtContraseña.Text);
                            if (validLogin == true)
                            {
                                switch (UsuarioLoginCache.tipo)
                                {
                                    case 1:
                                PanelGestor frmPanelGestor = new PanelGestor();
                                frmPanelGestor.Show();
                                frmPanelGestor.FormClosed += Logout;
                                this.Hide();
                                break;
                                    case 2:
                                PanelEmpleado frmPanelEmpleado = new PanelEmpleado();
                                frmPanelEmpleado.Show();
                                frmPanelEmpleado.FormClosed += Logout;
                                this.Hide();
                                break;
                                    case 3:
                                frmPanelAdministrador frmPanelAdmin = new frmPanelAdministrador();
                                frmPanelAdmin.Show();
                                frmPanelAdmin.FormClosed += Logout;
                                this.Hide();
                                 break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrecta . \n Intente otra vez");
                                txtContraseña.Text = "";
                                txtUsuario.Focus();
                            }
                        }
                        else MessageBox.Show("Ingrese contraseña");
                }
            else MessageBox.Show("Ingrese Codigo de usuario");
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        }  
    }

