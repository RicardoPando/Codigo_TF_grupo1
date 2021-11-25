
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
            this.dGVPlan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CLBBeneficios = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadDMoviles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVPlan);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes Existentes";
            // 
            // dGVPlan
            // 
            this.dGVPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlan.Location = new System.Drawing.Point(3, 16);
            this.dGVPlan.Name = "dGVPlan";
            this.dGVPlan.Size = new System.Drawing.Size(137, 350);
            this.dGVPlan.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CLBBeneficios);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCantidadDMoviles);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(158, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del plan";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // CLBBeneficios
            // 
            this.CLBBeneficios.CheckOnClick = true;
            this.CLBBeneficios.FormattingEnabled = true;
            this.CLBBeneficios.Items.AddRange(new object[] {
            "Claro Juegos",
            "Club Claro Apps",
            "Control Automatico",
            "Consumo Adicional"});
            this.CLBBeneficios.Location = new System.Drawing.Point(138, 148);
            this.CLBBeneficios.Name = "CLBBeneficios";
            this.CLBBeneficios.Size = new System.Drawing.Size(120, 19);
            this.CLBBeneficios.TabIndex = 16;
            this.CLBBeneficios.SelectedIndexChanged += new System.EventHandler(this.CLBBeneficios_SelectedIndexChanged);
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
            this.txtCantidadDMoviles.Location = new System.Drawing.Point(138, 113);
            this.txtCantidadDMoviles.Name = "txtCantidadDMoviles";
            this.txtCantidadDMoviles.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDMoviles.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cantidad de datos moviles";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(138, 75);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 78);
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
            // DTPFechaFinalizacion
            // 
            this.DTPFechaFinalizacion.Location = new System.Drawing.Point(14, 73);
            this.DTPFechaFinalizacion.Name = "DTPFechaFinalizacion";
            this.DTPFechaFinalizacion.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaFinalizacion.TabIndex = 3;
            // 
            // DTPFechaInicio
            // 
            this.DTPFechaInicio.Location = new System.Drawing.Point(14, 34);
            this.DTPFechaInicio.Name = "DTPFechaInicio";
            this.DTPFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaInicio.TabIndex = 4;
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
            this.groupBox3.Controls.Add(this.DTPFechaInicio);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DTPFechaFinalizacion);
            this.groupBox3.Location = new System.Drawing.Point(174, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo Disponible";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Crear Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GestionarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 430);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.DateTimePicker DTPFechaFinalizacion;
        private System.Windows.Forms.DateTimePicker DTPFechaInicio;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.CheckedListBox CLBBeneficios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVPlan;
    }
}