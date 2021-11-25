using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF_Grupo1.Presentacion.Gestor
{
    public partial class PanelGestor : Form
    {
        public PanelGestor()
        {
            InitializeComponent();
        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestionarPlan frmGestionarPlan = new GestionarPlan();
            frmGestionarPlan.Show();
            frmGestionarPlan.FormClosed += Logout;
            this.Hide();
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
