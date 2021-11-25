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
using Entidades;

namespace TF_Grupo1.Presentacion.EmpleadoVenta

{
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }
        eCliente objCliente = new eCliente();
        nCliente negCliente = new nCliente();

        private void button1_Click(object sender, EventArgs e)
        {
            objCliente.Nombre = textBox1.Text;
            objCliente.ApellidoPaterno = textBox2.Text;
            objCliente.ApellidoMaterno = textBox3.Text;
            objCliente.Dni = Convert.ToInt32(textBox4.Text);
            objCliente.NumeroCelular = Convert.ToInt32(textBox7.Text);
            negCliente.CrearCliente(objCliente);
            MessageBox.Show("Se registro el cliente corractamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelEmpleado VolverPanelEmpleado = new PanelEmpleado();
            VolverPanelEmpleado.Show();
            this.Hide();
        }
    }
}
