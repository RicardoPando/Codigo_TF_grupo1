using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Cache;
using Negocio;

namespace TF_Grupo1.Presentacion.Gestor
{
    public partial class GestionarPlan : Form
    {
        public GestionarPlan()
        {
            InitializeComponent();
            ListarPlan();
            lblCodigoGestor.Text = UsuarioLoginCache.codigo.ToString();
            //MessageBox.Show(CLBBeneficios.SelectedIndex.ToString());
        }

        string Operacion = "Insertar";
        nPlan negPlan = new nPlan();

        private void dGVPlan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Operacion = "Editar";
            txtCodigo.Text = dGVPlan.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dGVPlan.CurrentRow.Cells[1].Value.ToString();
            lblCodigoGestor.Text= dGVPlan.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dGVPlan.CurrentRow.Cells[3].Value.ToString();
            txtCantidadDMoviles.Text = dGVPlan.CurrentRow.Cells[4].Value.ToString();
            chkClaroJuegos.Checked=dGVPlan.CurrentRow.Cells[5].Selected;
            chkClaroApps.Checked = dGVPlan.CurrentRow.Cells[6].Selected;
            chkControlAutomatico.Checked = dGVPlan.CurrentRow.Cells[7].Selected;
            chkConsumoAdicional.Checked = dGVPlan.CurrentRow.Cells[8].Selected;
            FechaInicio(dGVPlan.CurrentRow.Cells[9].Value.ToString());
            FechaFin(dGVPlan.CurrentRow.Cells[10].Value.ToString());
            //MessageBox.Show(dGVPlan.CurrentRow.Cells[10].Value.ToString());
        }
        private void FechaInicio(string fechI)
        {
            cmbDiaInicio.Text = fechI.Substring(8,2);
            cmbMesInicio.Text = fechI.Substring(5, 2);
            cmbAñoInicio.Text = fechI.Substring(0, 4);
        }
        private void FechaFin(string fechF)
        {
            cmbDiaFin.Text = fechF.Substring(8, 2);
            cmbMesFin.Text = fechF.Substring(5, 2);
            cmbAñoFin.Text = fechF.Substring(0, 4);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dGVPlan.SelectedRows.Count>0)
            {
                negPlan.Eliminar(Convert.ToInt32(dGVPlan.CurrentRow.Cells[0].ToString()));
                ListarPlan();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtCantidadDMoviles.Text = "";
                chkClaroJuegos.Checked = false;
                chkClaroApps.Checked = false;
                chkControlAutomatico.Checked = false;
                chkConsumoAdicional.Checked = false;
                cmbDiaInicio.Text = "";
                cmbMesInicio.Text = "";
                cmbMesInicio.Text = "";
                cmbDiaFin.Text = "";
                cmbMesFin.Text = "";
                cmbMesFin.Text = "";
                MessageBox.Show("Se Elimino correctamente");
            }
            
        }

        private void ListarPlan()
        {
            dGVPlan.DataSource = negPlan.Listar();
        }



        ePlan objPlan = new ePlan();
        private void btnGuardar(object sender, EventArgs e)
        {
            if (Operacion=="Insertar")
            {
                objPlan.Codigo = Convert.ToInt32(txtCodigo.Text);
                objPlan.Nombre = txtNombre.Text.ToString();
                objPlan.CodigoGestor=Convert.ToInt32(lblCodigoGestor.Text);
                objPlan.Precio = Convert.ToInt32(txtPrecio.Text);
                objPlan.CantidadDatosMoviles = Convert.ToInt32(txtCantidadDMoviles.Text);
                objPlan.ClaroJuegos = chkClaroJuegos.Checked;
                objPlan.ClubClaroApps = chkClaroApps.Checked;
                objPlan.ControlAutamatico = chkControlAutomatico.Checked;
                objPlan.ConsumoAdicional = chkConsumoAdicional.Checked;
                objPlan.FechaInicio = string.Concat(cmbAñoInicio.Text + "-" + cmbMesInicio.Text + "-" + cmbDiaInicio.Text);
                objPlan.FechaFin = string.Concat(cmbAñoFin.Text + "-" + cmbMesFin.Text + "-" + cmbDiaFin.Text);
                negPlan.CrearPlan(objPlan);
                ListarPlan();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtCantidadDMoviles.Text = "";
                chkClaroJuegos.Checked = false;
                chkClaroApps.Checked = false;
                chkControlAutomatico.Checked = false;
                chkConsumoAdicional.Checked = false;
                cmbDiaInicio.Text = "";
                cmbMesInicio.Text = "";
                cmbMesInicio.Text = "";
                cmbDiaFin.Text = "";
                cmbMesFin.Text = "";
                cmbMesFin.Text = "";
                MessageBox.Show("Se inserto correctamente");
            }
            else if (Operacion=="Editar")
            {
            objPlan.Nombre = txtNombre.Text.ToString();
            objPlan.Precio = Convert.ToInt32(txtPrecio.Text);
            objPlan.CantidadDatosMoviles = Convert.ToInt32(txtCantidadDMoviles.Text);
            objPlan.ClaroJuegos = chkClaroJuegos.Checked;
            objPlan.ClubClaroApps = chkClaroApps.Checked;
            objPlan.ControlAutamatico = chkControlAutomatico.Checked;
            objPlan.ConsumoAdicional = chkConsumoAdicional.Checked;
            objPlan.FechaInicio=string.Concat(cmbAñoInicio.Text+"-"+cmbMesInicio.Text+"-"+cmbDiaInicio.Text);
            objPlan.FechaFin = string.Concat(cmbAñoFin.Text + "-" + cmbMesFin.Text + "-" + cmbDiaFin.Text);
            negPlan.EditarPlan(Convert.ToInt32(txtCodigo.Text),objPlan);
                ListarPlan();
                txtCodigo.Text=""; 
            txtNombre.Text="";
            txtPrecio.Text = "";
            txtCantidadDMoviles.Text = "";
            chkClaroJuegos.Checked = false;
            chkClaroApps.Checked = false;
            chkControlAutomatico.Checked = false;
            chkConsumoAdicional.Checked = false;
            cmbDiaInicio.Text="";
            cmbMesInicio.Text="";
            cmbMesInicio.Text="";
            cmbDiaFin.Text   ="";
            cmbMesFin.Text   ="";
            cmbMesFin.Text = "";
            MessageBox.Show("Se Edito correctamente");
            }
        }
    }
}
