namespace academica {
    partial class alumnos {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtDuiAlumno = new System.Windows.Forms.TextBox();
            this.lblDuiAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblNRegistroAlumno = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grdDatosAlumno = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumno = new System.Windows.Forms.Label();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.txtDuiAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblDuiAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblDireccionAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatosAlumnos.Enabled = false;
            this.grbDatosAlumnos.Location = new System.Drawing.Point(35, 27);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(434, 249);
            this.grbDatosAlumnos.TabIndex = 0;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "Datos";
            // 
            // txtDuiAlumno
            // 
            this.txtDuiAlumno.Location = new System.Drawing.Point(103, 202);
            this.txtDuiAlumno.Name = "txtDuiAlumno";
            this.txtDuiAlumno.Size = new System.Drawing.Size(305, 20);
            this.txtDuiAlumno.TabIndex = 9;
            // 
            // lblDuiAlumno
            // 
            this.lblDuiAlumno.AutoSize = true;
            this.lblDuiAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiAlumno.Location = new System.Drawing.Point(51, 201);
            this.lblDuiAlumno.Name = "lblDuiAlumno";
            this.lblDuiAlumno.Size = new System.Drawing.Size(36, 18);
            this.lblDuiAlumno.TabIndex = 8;
            this.lblDuiAlumno.Text = "Dui:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(103, 159);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(160, 20);
            this.txtTelefonoAlumno.TabIndex = 7;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(17, 158);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(70, 18);
            this.lblTelefonoAlumno.TabIndex = 6;
            this.lblTelefonoAlumno.Text = "Telefono:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(103, 116);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(305, 20);
            this.txtDireccionAlumno.TabIndex = 5;
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionAlumno.Location = new System.Drawing.Point(8, 115);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(79, 18);
            this.lblDireccionAlumno.TabIndex = 4;
            this.lblDireccionAlumno.Text = "Direccion:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(103, 76);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(305, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(19, 75);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(68, 18);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(103, 39);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(160, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAlumno.Location = new System.Drawing.Point(23, 38);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(64, 18);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "Codigo:";
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblNRegistroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(37, 310);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(247, 69);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblNRegistroAlumno
            // 
            this.lblNRegistroAlumno.AutoSize = true;
            this.lblNRegistroAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRegistroAlumno.Location = new System.Drawing.Point(76, 31);
            this.lblNRegistroAlumno.Name = "lblNRegistroAlumno";
            this.lblNRegistroAlumno.Size = new System.Drawing.Size(49, 18);
            this.lblNRegistroAlumno.TabIndex = 10;
            this.lblNRegistroAlumno.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(206, 19);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnUltimoAlumno.TabIndex = 3;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(169, 19);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnSiguienteAlumno.TabIndex = 2;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(39, 19);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(2, 19);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(37, 43);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(291, 310);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(347, 69);
            this.grbEdicionAlumno.TabIndex = 2;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(192, 19);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(86, 43);
            this.btnEliminarAlumno.TabIndex = 13;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.Location = new System.Drawing.Point(93, 19);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(97, 43);
            this.btnModificarAlumno.TabIndex = 12;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(86, 43);
            this.btnAgregarAlumno.TabIndex = 11;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grdDatosAlumno
            // 
            this.grdDatosAlumno.AllowUserToAddRows = false;
            this.grdDatosAlumno.AllowUserToDeleteRows = false;
            this.grdDatosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.dui});
            this.grdDatosAlumno.Location = new System.Drawing.Point(483, 65);
            this.grdDatosAlumno.Name = "grdDatosAlumno";
            this.grdDatosAlumno.ReadOnly = true;
            this.grdDatosAlumno.Size = new System.Drawing.Size(585, 239);
            this.grdDatosAlumno.TabIndex = 3;
            this.grdDatosAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosAlumno_CellClick);
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "idAlumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
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
            this.nombre.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 150;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 80;
            // 
            // dui
            // 
            this.dui.DataPropertyName = "dui";
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            this.dui.Width = 80;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Location = new System.Drawing.Point(547, 39);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(521, 20);
            this.txtBuscarAlumno.TabIndex = 10;
            this.txtBuscarAlumno.TextChanged += new System.EventHandler(this.txtBuscarAlumno_TextChanged);
            this.txtBuscarAlumno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumno_KeyUp);
            // 
            // lblBuscarAlumno
            // 
            this.lblBuscarAlumno.AutoSize = true;
            this.lblBuscarAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarAlumno.Location = new System.Drawing.Point(480, 39);
            this.lblBuscarAlumno.Name = "lblBuscarAlumno";
            this.lblBuscarAlumno.Size = new System.Drawing.Size(61, 18);
            this.lblBuscarAlumno.TabIndex = 10;
            this.lblBuscarAlumno.Text = "Buscar:";
            // 
            // alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 420);
            this.Controls.Add(this.lblBuscarAlumno);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.grdDatosAlumno);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Name = "alumnos";
            this.Text = "Administracion de Alumnos";
            this.Load += new System.EventHandler(this.alumnos_Load);
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.TextBox txtDuiAlumno;
        private System.Windows.Forms.Label lblDuiAlumno;
        private System.Windows.Forms.Label lblNRegistroAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.DataGridView grdDatosAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.Label lblBuscarAlumno;
    }
}

