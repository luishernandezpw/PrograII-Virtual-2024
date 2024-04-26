namespace interfaz {
    partial class conversores {
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
            btnConvertir = new Button();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            txtcantidad = new TextBox();
            lblDe = new Label();
            cboDe = new ComboBox();
            lblA = new Label();
            cboA = new ComboBox();
            lblCantidad = new Label();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(81, 287);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(207, 62);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Monedas", "Tiempo", "Longitud" });
            cboTipo.Location = new Point(105, 39);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(238, 23);
            cboTipo.TabIndex = 1;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;            
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(36, 39);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 18);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "TIPO:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(126, 193);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(208, 23);
            txtcantidad.TabIndex = 3;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDe.Location = new Point(36, 87);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(35, 18);
            lblDe.TabIndex = 5;
            lblDe.Text = "DE:";
            // 
            // cboDe
            // 
            cboDe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDe.FormattingEnabled = true;
            cboDe.Location = new Point(105, 87);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(238, 23);
            cboDe.TabIndex = 4;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.Location = new Point(36, 140);
            lblA.Name = "lblA";
            lblA.Size = new Size(23, 18);
            lblA.TabIndex = 7;
            lblA.Text = "A:";
            // 
            // cboA
            // 
            cboA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboA.FormattingEnabled = true;
            cboA.Location = new Point(105, 140);
            cboA.Name = "cboA";
            cboA.Size = new Size(238, 23);
            cboA.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(27, 198);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(93, 18);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "CANTIDAD:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(36, 245);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(100, 18);
            lblRespuesta.TabIndex = 9;
            lblRespuesta.Text = "Respuesta: ?";
            // 
            // conversores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 378);
            Controls.Add(lblRespuesta);
            Controls.Add(lblCantidad);
            Controls.Add(lblA);
            Controls.Add(cboA);
            Controls.Add(lblDe);
            Controls.Add(cboDe);
            Controls.Add(txtcantidad);
            Controls.Add(lblTipo);
            Controls.Add(cboTipo);
            Controls.Add(btnConvertir);
            Name = "conversores";
            Text = "Conversores";
            Load += conversores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private ComboBox cboTipo;
        private Label lblTipo;
        private TextBox txtcantidad;
        private Label lblDe;
        private ComboBox cboDe;
        private Label lblA;
        private ComboBox cboA;
        private Label lblCantidad;
        private Label lblRespuesta;
    }
}