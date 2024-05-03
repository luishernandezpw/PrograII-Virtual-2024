namespace academica {
    partial class materias {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblBuscarMateria = new System.Windows.Forms.Label();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grdDatosMateria = new System.Windows.Forms.DataGridView();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblNRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).BeginInit();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarMateria
            // 
            this.lblBuscarMateria.AutoSize = true;
            this.lblBuscarMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMateria.Location = new System.Drawing.Point(457, 36);
            this.lblBuscarMateria.Name = "lblBuscarMateria";
            this.lblBuscarMateria.Size = new System.Drawing.Size(61, 18);
            this.lblBuscarMateria.TabIndex = 15;
            this.lblBuscarMateria.Text = "Buscar:";
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(524, 36);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(360, 20);
            this.txtBuscarMateria.TabIndex = 16;
            this.txtBuscarMateria.TextChanged += new System.EventHandler(this.txtBuscarMateria_TextChanged);
            this.txtBuscarMateria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMateria_KeyUp);
            // 
            // grdDatosMateria
            // 
            this.grdDatosMateria.AllowUserToAddRows = false;
            this.grdDatosMateria.AllowUserToDeleteRows = false;
            this.grdDatosMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdDatosMateria.Location = new System.Drawing.Point(460, 62);
            this.grdDatosMateria.Name = "grdDatosMateria";
            this.grdDatosMateria.ReadOnly = true;
            this.grdDatosMateria.Size = new System.Drawing.Size(424, 239);
            this.grdDatosMateria.TabIndex = 14;
            this.grdDatosMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMateria_CellClick);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(268, 307);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Size = new System.Drawing.Size(289, 69);
            this.grbEdicionMateria.TabIndex = 13;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(192, 19);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(86, 43);
            this.btnEliminarMateria.TabIndex = 13;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(93, 19);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(97, 43);
            this.btnModificarMateria.TabIndex = 12;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(86, 43);
            this.btnAgregarMateria.TabIndex = 11;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblNRegistroMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(14, 307);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(247, 69);
            this.grbNavegacionMateria.TabIndex = 12;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblNRegistroMateria
            // 
            this.lblNRegistroMateria.AutoSize = true;
            this.lblNRegistroMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRegistroMateria.Location = new System.Drawing.Point(76, 31);
            this.lblNRegistroMateria.Name = "lblNRegistroMateria";
            this.lblNRegistroMateria.Size = new System.Drawing.Size(49, 18);
            this.lblNRegistroMateria.TabIndex = 10;
            this.lblNRegistroMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(206, 19);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(37, 43);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(169, 19);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(37, 43);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(39, 19);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(37, 43);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(2, 19);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(37, 43);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Location = new System.Drawing.Point(12, 24);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(434, 172);
            this.grbDatosMateria.TabIndex = 11;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(103, 116);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(305, 20);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUvMateria.Location = new System.Drawing.Point(54, 115);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(33, 18);
            this.lblUvMateria.TabIndex = 4;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(103, 76);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(305, 20);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(19, 75);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(68, 18);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "Nombre:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(103, 39);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(160, 20);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMateria.Location = new System.Drawing.Point(23, 38);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(64, 18);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "Codigo:";
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 60;
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 406);
            this.Controls.Add(this.lblBuscarMateria);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.grdDatosMateria);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "materias";
            this.Text = "materias";
            this.Load += new System.EventHandler(this.materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMateria)).EndInit();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.DataGridView grdDatosMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblNRegistroMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}