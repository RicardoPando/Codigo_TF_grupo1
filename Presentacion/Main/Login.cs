using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;

namespace TF_Grupo1.Presentacion.Main
{
    public partial class Login : Form
    {
        //private ConexionBD Conexion = new ConexionBD();
        //private SqlCommand Comando = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Comando.Connection = Conexion.AbrirConexion();
            //Conexion.CerrarConexion();
            //            InsertForm insertForm = new InsertForm();
            //            insertForm.ShowDialog();
        }

        private void linkResgitrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrarCliente frmRegistrarClienteForm = new frmRegistrarCliente();
            frmRegistrarClienteForm.ShowDialog();
        }
    }
}
