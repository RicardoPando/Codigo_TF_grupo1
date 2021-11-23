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
        }
        private void frmPanelAdministrador_Load(object sender, EventArgs e)
        {   
            ListarUsuarios();
            cmbTipo.Text = "seleccione tipo";
            cmbFiltrarUser.Text = "seleccione tipo";
            SelectedIndex = false;
        }
        bool SelectedIndex;
        eUsuario objuser = new eUsuario();
        usuarioModel NegocioUser = new usuarioModel();
        private bool CamposLlenos()
        {
            if (txtCodigo.Text != "" &&
            txtContraseña.Text != "" &&
            cmbTipo.Text != "" &&
            txtNombre.Text != "" &&
            txtApellidoPaterno.Text != "" &&
            txtApellidoMaterno.Text != "" &&
            txtDni.Text != "" &&
            txtNumeroCelular.Text != "")
            {
                return true;
            }
            else return false;  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (CamposLlenos())
            {
                if (Operacion == "Insertar")
                {
                    objuser.Codigo = Convert.ToInt32(txtCodigo.Text);
                    objuser.Contraseña = txtContraseña.Text;
                    objuser.Tipo = Convert.ToInt32(cmbTipo.SelectedValue);
                    objuser.Nombre = txtNombre.Text;
                    objuser.ApellidoPaterno = txtApellidoPaterno.Text;
                    objuser.ApellidoMaterno = txtApellidoMaterno.Text;
                    objuser.Dni = Convert.ToInt32(txtDni.Text);
                    objuser.NumeroCelular = txtNumeroCelular.Text;
                    NegocioUser.CrearUsuario(objuser);
                    ListarUsuarios();
                    txtCodigo.Text = "";
                    txtContraseña.Text = "";
                    cmbTipo.Text = "seleccione tipo";
                    txtNombre.Text = "";
                    txtApellidoPaterno.Text = "";
                    txtApellidoMaterno.Text = "";
                    txtDni.Text = "";
                    txtNumeroCelular.Text = "";
                    MessageBox.Show("Se inserto correctamente");
                }
                else if (Operacion == "Editar")
                {
                    objuser.Codigo = Convert.ToInt32(txtCodigo.Text);
                    objuser.Contraseña = txtContraseña.Text;
                    objuser.Tipo = Convert.ToInt32(cmbTipo.SelectedValue);
                    objuser.Nombre = txtNombre.Text;
                    objuser.ApellidoPaterno = txtApellidoPaterno.Text;
                    objuser.ApellidoMaterno = txtApellidoMaterno.Text;
                    objuser.Dni = Convert.ToInt32(txtDni.Text);
                    objuser.NumeroCelular = txtNumeroCelular.Text;

                    NegocioUser.EditarUsuario(objuser.Codigo, objuser);

                    ListarUsuarios();
                    MessageBox.Show("Se edito correctamente");
                    txtCodigo.Text = "";
                    txtContraseña.Text = "";
                    cmbTipo.Text = "seleccione tipo";
                    txtNombre.Text = "";
                    txtApellidoPaterno.Text = "";
                    txtApellidoMaterno.Text = "";
                    txtDni.Text = "";
                    txtNumeroCelular.Text = "";
                    Operacion = "Insertar";
                }
            }
            else
            {
                MessageBox.Show("LLene Correctamente los campos");
            }
        }
        private void cmbFiltrarUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndex != false)
            {
                dataGridView1.DataSource = NegocioUser.filtrarSegunIdTipo(Convert.ToInt32(cmbFiltrarUser.SelectedValue));
            }
        }

        private void cmbFiltrarUser_Click(object sender, EventArgs e)
        {
            SelectedIndex = true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Operacion != "Editar"/*&& Operacion == "Ingresar" */&& ((txtCodigo.Text.Length < 8)&& (((char.IsNumber(e.KeyChar)))|| (e.KeyChar == (char)Keys.Back))))
            {
                e.Handled = false;
            }
            else if (/*Operacion == "Editar"&&*/((((char.IsNumber(e.KeyChar))) || (txtCodigo.Text.Length >= 8)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtContraseña.Text.Length >= 15) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtNombre.Text.Length >= 15)||(char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtApellidoPaterno.Text.Length >= 15) || (char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtApellidoMaterno.Text.Length >= 15) || (char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtDni.Text.Length >= 8) || !(char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || Operacion == "Editar")
            {
                e.Handled = false;
            }
            else if ((txtNumeroCelular.Text.Length >= 9)|| !(char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void ListarComboTipoUsuario()
        {
            cmbTipo.DataSource = NegocioUser.ComboTipoUsuario();
            cmbTipo.DisplayMember = "nombre";
            cmbTipo.ValueMember = "id";
            
            cmbFiltrarUser.DataSource = NegocioUser.ComboTipoUsuario();
            cmbFiltrarUser.DisplayMember = "nombre";
            cmbFiltrarUser.ValueMember = "id";
            
        }

        private void cmbFiltrarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        string Operacion = "Insertar";



        private void ListarUsuarios()
        {
            dataGridView1.DataSource = NegocioUser.Listar();
            ListarComboTipoUsuario();

        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                Operacion = "Editar";
                cmbTipo.Text = NegocioUser.NombreTipoUsuario(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
                cmbTipo.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtApellidoPaterno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtApellidoMaterno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtDni.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtNumeroCelular.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }else MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objuser.Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                NegocioUser.Eliminar(objuser.Codigo);
                ListarUsuarios();
                MessageBox.Show("Se elimino Correctamente");
            }
            else MessageBox.Show("Debe seleccionar una fila");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            SelectedIndex = false;
            ListarUsuarios();
            cmbFiltrarUser.Text = "seleccione tipo";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Operacion = "Ingresar";
            txtCodigo.Text = "";
            txtContraseña.Text = "";
            cmbTipo.Text = "seleccione tipo";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDni.Text = "";
            txtNumeroCelular.Text = "";
        }
    }
}
