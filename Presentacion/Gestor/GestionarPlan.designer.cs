
namespace TF_Grupo1.Presentacion.Gestor
{
    partial class GestionarPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPlan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dGVPlan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkConsumoAdicional = new System.Windows.Forms.CheckBox();
            this.chkControlAutomatico = new System.Windows.Forms.CheckBox();
            this.chkClaroApps = new System.Windows.Forms.CheckBox();
            this.chkClaroJuegos = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadDMoviles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAñoFin = new System.Windows.Forms.ComboBox();
            this.cmbMesFin = new System.Windows.Forms.ComboBox();
            this.cmbDiaFin = new System.Windows.Forms.ComboBox();
            this.cmbAñoInicio = new System.Windows.Forms.ComboBox();
            this.cmbMesInicio = new System.Windows.Forms.ComboBox();
            this.cmbDiaInicio = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigoGestor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.dGVPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes Existentes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(32, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dGVPlan
            // 
            this.dGVPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlan.Location = new System.Drawing.Point(3, 16);
            this.dGVPlan.Name = "dGVPlan";
            this.dGVPlan.Size = new System.Drawing.Size(137, 350);
            this.dGVPlan.TabIndex = 9;
            this.dGVPlan.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVPlan_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCodigoGestor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkConsumoAdicional);
            this.groupBox2.Controls.Add(this.chkControlAutomatico);
            this.groupBox2.Controls.Add(this.chkClaroApps);
            this.groupBox2.Controls.Add(this.chkClaroJuegos);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCantidadDMoviles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del plan";
            // 
            // chkConsumoAdicional
            // 
            this.chkConsumoAdicional.AutoSize = true;
            this.chkConsumoAdicional.Location = new System.Drawing.Point(158, 217);
            this.chkConsumoAdicional.Name = "chkConsumoAdicional";
            this.chkConsumoAdicional.Size = new System.Drawing.Size(113, 17);
            this.chkConsumoAdicional.TabIndex = 23;
            this.chkConsumoAdicional.Text = "ConsumoAdicional";
            this.chkConsumoAdicional.UseVisualStyleBackColor = true;
            // 
            // chkControlAutomatico
            // 
            this.chkControlAutomatico.AutoSize = true;
            this.chkControlAutomatico.Location = new System.Drawing.Point(19, 217);
            this.chkControlAutomatico.Name = "chkControlAutomatico";
            this.chkControlAutomatico.Size = new System.Drawing.Size(115, 17);
            this.chkControlAutomatico.TabIndex = 22;
            this.chkControlAutomatico.Text = "Control Automatico";
            this.chkControlAutomatico.UseVisualStyleBackColor = true;
            // 
            // chkClaroApps
            // 
            this.chkClaroApps.AutoSize = true;
            this.chkClaroApps.Location = new System.Drawing.Point(158, 183);
            this.chkClaroApps.Name = "chkClaroApps";
            this.chkClaroApps.Size = new System.Drawing.Size(77, 17);
            this.chkClaroApps.TabIndex = 21;
            this.chkClaroApps.Text = "Claro Apps";
            this.chkClaroApps.UseVisualStyleBackColor = true;
            // 
            // chkClaroJuegos
            // 
            this.chkClaroJuegos.AutoSize = true;
            this.chkClaroJuegos.Location = new System.Drawing.Point(19, 183);
            this.chkClaroJuegos.Name = "chkClaroJuegos";
            this.chkClaroJuegos.Size = new System.Drawing.Size(87, 17);
            this.chkClaroJuegos.TabIndex = 20;
            this.chkClaroJuegos.Text = "Claro Juegos";
            this.chkClaroJuegos.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Beneficios Adicionales";
            // 
            // txtCantidadDMoviles
            // 
            this.txtCantidadDMoviles.Location = new System.Drawing.Point(138, 129);
            this.txtCantidadDMoviles.Name = "txtCantidadDMoviles";
            this.txtCantidadDMoviles.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDMoviles.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad de datos moviles";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(138, 101);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Finalizacion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAñoFin);
            this.groupBox3.Controls.Add(this.cmbMesFin);
            this.groupBox3.Controls.Add(this.cmbDiaFin);
            this.groupBox3.Controls.Add(this.cmbAñoInicio);
            this.groupBox3.Controls.Add(this.cmbMesInicio);
            this.groupBox3.Controls.Add(this.cmbDiaInicio);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(177, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo Disponible";
            // 
            // cmbAñoFin
            // 
            this.cmbAñoFin.FormattingEnabled = true;
            this.cmbAñoFin.Location = new System.Drawing.Point(153, 73);
            this.cmbAñoFin.Name = "cmbAñoFin";
            this.cmbAñoFin.Size = new System.Drawing.Size(58, 21);
            this.cmbAñoFin.TabIndex = 12;
            // 
            // cmbMesFin
            // 
            this.cmbMesFin.FormattingEnabled = true;
            this.cmbMesFin.Location = new System.Drawing.Point(96, 73);
            this.cmbMesFin.Name = "cmbMesFin";
            this.cmbMesFin.Size = new System.Drawing.Size(51, 21);
            this.cmbMesFin.TabIndex = 11;
            // 
            // cmbDiaFin
            // 
            this.cmbDiaFin.FormattingEnabled = true;
            this.cmbDiaFin.Location = new System.Drawing.Point(42, 73);
            this.cmbDiaFin.Name = "cmbDiaFin";
            this.cmbDiaFin.Size = new System.Drawing.Size(48, 21);
            this.cmbDiaFin.TabIndex = 10;
            // 
            // cmbAñoInicio
            // 
            this.cmbAñoInicio.FormattingEnabled = true;
            this.cmbAñoInicio.Location = new System.Drawing.Point(153, 35);
            this.cmbAñoInicio.Name = "cmbAñoInicio";
            this.cmbAñoInicio.Size = new System.Drawing.Size(58, 21);
            this.cmbAñoInicio.TabIndex = 9;
            // 
            // cmbMesInicio
            // 
            this.cmbMesInicio.FormattingEnabled = true;
            this.cmbMesInicio.Location = new System.Drawing.Point(96, 35);
            this.cmbMesInicio.Name = "cmbMesInicio";
            this.cmbMesInicio.Size = new System.Drawing.Size(51, 21);
            this.cmbMesInicio.TabIndex = 8;
            // 
            // cmbDiaInicio
            // 
            this.cmbDiaInicio.FormattingEnabled = true;
            this.cmbDiaInicio.Location = new System.Drawing.Point(42, 35);
            this.cmbDiaInicio.Name = "cmbDiaInicio";
            this.cmbDiaInicio.Size = new System.Drawing.Size(48, 21);
            this.cmbDiaInicio.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnGuardar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Código Gestor";
            // 
            // lblCodigoGestor
            // 
            this.lblCodigoGestor.AutoSize = true;
            this.lblCodigoGestor.Location = new System.Drawing.Point(169, 50);
            this.lblCodigoGestor.Name = "lblCodigoGestor";
            this.lblCodigoGestor.Size = new System.Drawing.Size(16, 13);
            this.lblCodigoGestor.TabIndex = 25;
            this.lblCodigoGestor.Text = "...";
            // 
            // GestionarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionarPlan";
            this.Text = "GestorPlan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadDMoviles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVPlan;
        private System.Windows.Forms.CheckBox chkConsumoAdicional;
        private System.Windows.Forms.CheckBox chkControlAutomatico;
        private System.Windows.Forms.CheckBox chkClaroApps;
        private System.Windows.Forms.CheckBox chkClaroJuegos;
        private System.Windows.Forms.ComboBox cmbAñoFin;
        private System.Windows.Forms.ComboBox cmbMesFin;
        private System.Windows.Forms.ComboBox cmbDiaFin;
        private System.Windows.Forms.ComboBox cmbAñoInicio;
        private System.Windows.Forms.ComboBox cmbMesInicio;
        private System.Windows.Forms.ComboBox cmbDiaInicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoGestor;
        private System.Windows.Forms.Label label5;
    }
}