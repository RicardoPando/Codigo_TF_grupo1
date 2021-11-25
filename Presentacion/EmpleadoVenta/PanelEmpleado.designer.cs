
namespace TF_Grupo1.Presentacion.EmpleadoVenta
{
    partial class PanelEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private void InitializeComponent()
        {
            //EmpresaClaroDataSet1 dgvPlanes = new EmpresaClaroDataSet1();
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelEmpleado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dGVPlanCliente = new System.Windows.Forms.DataGridView();
            this.btnDesuscribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlanSeleccionado = new System.Windows.Forms.Label();
            this.lblClienteSelec = new System.Windows.Forms.Label();
            this.dGVPlan = new System.Windows.Forms.DataGridView();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVCliente = new System.Windows.Forms.DataGridView();
            //this.empresaClaroDataSet1 = new EmpresaClaroDataSet1();
            this.planBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
           //this.planTableAdapter = new Presentacion.EmpresaClaroDataSet1TableAdapters.planTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlanCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCliente)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.empresaClaroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dGVPlanCliente);
            this.groupBox1.Controls.Add(this.btnDesuscribir);
            this.groupBox1.Location = new System.Drawing.Point(354, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes del Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dGVPlanCliente
            // 
            this.dGVPlanCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlanCliente.Location = new System.Drawing.Point(9, 42);
            this.dGVPlanCliente.Name = "dGVPlanCliente";
            this.dGVPlanCliente.Size = new System.Drawing.Size(319, 186);
            this.dGVPlanCliente.TabIndex = 3;
            // 
            // btnDesuscribir
            // 
            this.btnDesuscribir.Location = new System.Drawing.Point(14, 13);
            this.btnDesuscribir.Name = "btnDesuscribir";
            this.btnDesuscribir.Size = new System.Drawing.Size(75, 23);
            this.btnDesuscribir.TabIndex = 2;
            this.btnDesuscribir.Text = "Desuscribir";
            this.btnDesuscribir.UseVisualStyleBackColor = true;
            this.btnDesuscribir.Click += new System.EventHandler(this.btnDesuscribir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un Cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(26, 27);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(127, 23);
            this.btnRegistrarCliente.TabIndex = 4;
            this.btnRegistrarCliente.Text = "Registrar Nuevo Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(124, 191);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlanSeleccionado);
            this.groupBox2.Controls.Add(this.lblClienteSelec);
            this.groupBox2.Controls.Add(this.dGVPlan);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnInscribir);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planes Disponibles";
            // 
            // lblPlanSeleccionado
            // 
            this.lblPlanSeleccionado.AutoSize = true;
            this.lblPlanSeleccionado.Location = new System.Drawing.Point(223, 213);
            this.lblPlanSeleccionado.Name = "lblPlanSeleccionado";
            this.lblPlanSeleccionado.Size = new System.Drawing.Size(96, 13);
            this.lblPlanSeleccionado.TabIndex = 9;
            this.lblPlanSeleccionado.Text = "Plan Seleccionado";
            // 
            // lblClienteSelec
            // 
            this.lblClienteSelec.AutoSize = true;
            this.lblClienteSelec.Location = new System.Drawing.Point(11, 213);
            this.lblClienteSelec.Name = "lblClienteSelec";
            this.lblClienteSelec.Size = new System.Drawing.Size(107, 13);
            this.lblClienteSelec.TabIndex = 8;
            this.lblClienteSelec.Text = "Cliente Seleccionado";
            // 
            // dGVPlan
            // 
            this.dGVPlan.AutoGenerateColumns = false;
            this.dGVPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dGVPlan.DataSource = this.planBindingSource1;
            this.dGVPlan.Location = new System.Drawing.Point(9, 46);
            this.dGVPlan.Name = "dGVPlan";
            this.dGVPlan.Size = new System.Drawing.Size(319, 129);
            this.dGVPlan.TabIndex = 7;
            this.dGVPlan.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVPlan_RowHeaderMouseClick);
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataMember = "plan";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(260, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cerrar sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione un plan ";
            // 
            // dGVCliente
            // 
            this.dGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCliente.Location = new System.Drawing.Point(12, 58);
            this.dGVCliente.Name = "dGVCliente";
            this.dGVCliente.Size = new System.Drawing.Size(327, 416);
            this.dGVCliente.TabIndex = 6;
            this.dGVCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVCliente_RowHeaderMouseClick);
            // 
            // empresaClaroDataSet1
            // 
          // this.empresaClaroDataSet1.DataSetName = "EmpresaClaroDataSet1";
          //  this.empresaClaroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planBindingSource1
            // 
            this.planBindingSource1.DataMember = "plan";
           // this.planBindingSource1.DataSource = this.empresaClaroDataSet1;
            // 
            // planTableAdapter
            // 
           // this.planTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigoGestor";
            this.dataGridViewTextBoxColumn3.HeaderText = "codigoGestor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidadDatosMoviles";
            this.dataGridViewTextBoxColumn5.HeaderText = "cantidadDatosMoviles";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "beneficiosAdicionales";
            this.dataGridViewTextBoxColumn6.HeaderText = "beneficiosAdicionales";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fechaInicio";
            this.dataGridViewTextBoxColumn7.HeaderText = "fechaInicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fechaFin";
            this.dataGridViewTextBoxColumn8.HeaderText = "fechaFin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PanelEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 521);
            this.Controls.Add(this.dGVCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelEmpleado";
            this.Text = "Panel Empleado";
            this.Load += new System.EventHandler(this.PanelEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlanCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCliente)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.empresaClaroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesuscribir;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dGVPlanCliente;
        private System.Windows.Forms.DataGridView dGVPlan;
        private System.Windows.Forms.DataGridView dGVCliente;
        private System.Windows.Forms.Label lblPlanSeleccionado;
        private System.Windows.Forms.Label lblClienteSelec;
        private System.Windows.Forms.ComboBox comboBox1;
       // private Presentacion.EmpresaClaroDataSet empresaClaroDataSet;
        private System.Windows.Forms.BindingSource planBindingSource;
       // private Presentacion.EmpresaClaroDataSetTableAdapters.planTableAdapter planTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoGestorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDatosMovilesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiosAdicionalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
       // private Presentacion.EmpresaClaroDataSet1 empresaClaroDataSet1;
        private System.Windows.Forms.BindingSource planBindingSource1;
       //private Presentacion.EmpresaClaroDataSet1TableAdapters.planTableAdapter planTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}