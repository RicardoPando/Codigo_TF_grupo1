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
using Entidades;
using Negocio;

namespace TF_Grupo1.Presentacion.EmpleadoVenta
{
    public partial class PanelEmpleado : Form
    {
        public PanelEmpleado()
        {
            InitializeComponent();
        }
        private void PanelEmpleado_Load(object sender, EventArgs e)
        {
            ListarPlanCliente();
            dGVPlan.DataSource = negPlan.Listar();
            ListarClientes      ();
        }

        eVenta Venta = new eVenta();
        nVenta negVenta = new nVenta();
        nPlan negPlan=new nPlan();
        nCliente negCliente =new nCliente()   ;
        bool ClienteSelec = false;
        bool PlanSelec = false;
        private void dGVCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblClienteSelec.Text = dGVCliente.CurrentRow.Cells[0].Value.ToString();
            ClienteSelec = true;
        }
        private void dGVPlan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblPlanSeleccionado.Text = dGVPlan.CurrentRow.Cells[0].Value.ToString();
            PlanSelec = true;
        }

        private void ListarPlanCliente()
        {
            dGVPlanCliente.DataSource = negVenta.ListarPlanCliente();
        }

        private void ListarPlan()
        {
            dGVPlan.DataSource = negPlan.Listar();
        }
        private void ListarClientes()
        {
            dGVCliente.DataSource = negCliente.Listar();
        }
        private void btnDesuscribir_Click(object sender, EventArgs e)
        {
            if (dGVPlanCliente.SelectedRows.Count>0)
            {
                int codigo = new int();
                codigo = Convert.ToInt32(dGVPlanCliente.CurrentRow.Cells[0].Value);
                negVenta.EliminarPlanCliente(codigo);
                ListarPlanCliente();
            }
            else MessageBox.Show("Seleccione una fila para ELIMINAR UN PLAN DE UN CLIENTE");
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (ClienteSelec==true&&PlanSelec==true)
            {
                Random rnd = new Random();
                Venta.CodigoVenta = rnd.Next(99999999, 999999999);
                Venta.CodigoEmpleado = Convert.ToInt32(UsuarioLoginCache.codigo);
                Venta.DniCliente = Convert.ToInt32(lblClienteSelec.Text);
                Venta.CodigoPlan = Convert.ToInt32(lblPlanSeleccionado.Text);
                //
                negVenta.CrearVenta(Venta);
                ListarPlanCliente();
                lblClienteSelec.Text = "Seleccione un Cliente";
                lblPlanSeleccionado.Text = "Seleccione un Plan";
                ClienteSelec = false;
                PlanSelec = false;
            }
            else MessageBox.Show("Seleccione cliente y plan");
        }   

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente RegistrarCliente = new frmRegistrarCliente();
            RegistrarCliente.Show();
            RegistrarCliente.FormClosed += ListarNuevoCliente;
            this.Hide();
        }
        private void ListarNuevoCliente(object sender, EventArgs e)
        {
            this.Show();
            ListarClientes();
        }

      
    }
}
