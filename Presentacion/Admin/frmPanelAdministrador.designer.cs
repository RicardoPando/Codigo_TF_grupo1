
namespace TF_Grupo1.Presentacion.Admin
{
    partial class frmPanelAdministrador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbFiltrarUser = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cmbFiltrarUser);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion de usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 273);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flitrar Usuarios";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(516, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbFiltrarUser
            // 
            this.cmbFiltrarUser.FormattingEnabled = true;
            this.cmbFiltrarUser.Location = new System.Drawing.Point(6, 34);
            this.cmbFiltrarUser.Name = "cmbFiltrarUser";
            this.cmbFiltrarUser.Size = new System.Drawing.Size(149, 21);
            this.cmbFiltrarUser.TabIndex = 4;
            this.cmbFiltrarUser.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarUser_SelectedIndexChanged);
            this.cmbFiltrarUser.Click += new System.EventHandler(this.cmbFiltrarUser_Click);
            this.cmbFiltrarUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFiltrarUser_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(757, 97);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 49;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Contraseña";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(757, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 47;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Código";
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Location = new System.Drawing.Point(757, 228);
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCelular.TabIndex = 45;
            this.txtNumeroCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCelular_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Numero de Celular";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(720, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(720, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(757, 201);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 41;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "DNI";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(757, 175);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMaterno.TabIndex = 39;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(757, 149);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoPaterno.TabIndex = 37;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(757, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nombre";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Seleccione el tipo de usuario",
            "Gestor",
            "Empleado",
            "Admin"});
            this.cmbTipo.Location = new System.Drawing.Point(720, 40);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(146, 21);
            this.cmbTipo.TabIndex = 33;
            this.cmbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tipo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(178, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPanelAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 367);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroCelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPanelAdministrador";
            this.Text = "Panel Administrador";
            this.Load += new System.EventHandler(this.frmPanelAdministrador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltrarUser;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}