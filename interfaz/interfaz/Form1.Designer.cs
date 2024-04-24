namespace interfaz {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnCalcular = new Button();
            txtNum1 = new TextBox();
            llbNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            rgpOpciones = new GroupBox();
            optDivision = new RadioButton();
            optMultiplicacion = new RadioButton();
            optResta = new RadioButton();
            optSuma = new RadioButton();
            lblRespuesta = new Label();
            optPorcentaje = new RadioButton();
            optRaiz = new RadioButton();
            optExponente = new RadioButton();
            rgpOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(34, 170);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(215, 45);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnSaludo_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(96, 44);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(78, 23);
            txtNum1.TabIndex = 1;
            // 
            // llbNum1
            // 
            llbNum1.AutoSize = true;
            llbNum1.Font = new Font("Segoe UI", 14.25F);
            llbNum1.Location = new Point(18, 39);
            llbNum1.Name = "llbNum1";
            llbNum1.Size = new Size(72, 25);
            llbNum1.TabIndex = 2;
            llbNum1.Text = "Num 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 14.25F);
            lblNum2.Location = new Point(18, 79);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(72, 25);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Num 2:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(96, 84);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(78, 23);
            txtNum2.TabIndex = 3;
            // 
            // rgpOpciones
            // 
            rgpOpciones.Controls.Add(optExponente);
            rgpOpciones.Controls.Add(optRaiz);
            rgpOpciones.Controls.Add(optPorcentaje);
            rgpOpciones.Controls.Add(optDivision);
            rgpOpciones.Controls.Add(optMultiplicacion);
            rgpOpciones.Controls.Add(optResta);
            rgpOpciones.Controls.Add(optSuma);
            rgpOpciones.Location = new Point(285, 34);
            rgpOpciones.Name = "rgpOpciones";
            rgpOpciones.Size = new Size(164, 207);
            rgpOpciones.TabIndex = 5;
            rgpOpciones.TabStop = false;
            rgpOpciones.Text = "Opciones";
            // 
            // optDivision
            // 
            optDivision.AutoSize = true;
            optDivision.Location = new Point(18, 100);
            optDivision.Name = "optDivision";
            optDivision.Size = new Size(73, 19);
            optDivision.TabIndex = 3;
            optDivision.Text = "DIVISION";
            optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            optMultiplicacion.AutoSize = true;
            optMultiplicacion.Location = new Point(18, 75);
            optMultiplicacion.Name = "optMultiplicacion";
            optMultiplicacion.Size = new Size(119, 19);
            optMultiplicacion.TabIndex = 2;
            optMultiplicacion.Text = "MULTIPLICACION";
            optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            optResta.AutoSize = true;
            optResta.Location = new Point(18, 50);
            optResta.Name = "optResta";
            optResta.Size = new Size(57, 19);
            optResta.TabIndex = 1;
            optResta.Text = "RESTA";
            optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            optSuma.AutoSize = true;
            optSuma.Checked = true;
            optSuma.Location = new Point(18, 25);
            optSuma.Name = "optSuma";
            optSuma.Size = new Size(58, 19);
            optSuma.TabIndex = 0;
            optSuma.TabStop = true;
            optSuma.Text = "SUMA";
            optSuma.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(18, 125);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(132, 22);
            lblRespuesta.TabIndex = 6;
            lblRespuesta.Text = "Respuesta: ?";
            // 
            // optPorcentaje
            // 
            optPorcentaje.AutoSize = true;
            optPorcentaje.Location = new Point(18, 125);
            optPorcentaje.Name = "optPorcentaje";
            optPorcentaje.Size = new Size(95, 19);
            optPorcentaje.TabIndex = 4;
            optPorcentaje.Text = "PORCENTAJE";
            optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optRaiz
            // 
            optRaiz.AutoSize = true;
            optRaiz.Location = new Point(18, 151);
            optRaiz.Name = "optRaiz";
            optRaiz.Size = new Size(50, 19);
            optRaiz.TabIndex = 5;
            optRaiz.Text = "RAIZ";
            optRaiz.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            optExponente.AutoSize = true;
            optExponente.Location = new Point(18, 182);
            optExponente.Name = "optExponente";
            optExponente.Size = new Size(126, 19);
            optExponente.TabIndex = 6;
            optExponente.Text = "EXPONENCIACION";
            optExponente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 253);
            Controls.Add(lblRespuesta);
            Controls.Add(rgpOpciones);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(llbNum1);
            Controls.Add(txtNum1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Calculadora";
            rgpOpciones.ResumeLayout(false);
            rgpOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNum1;
        private Label llbNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private GroupBox rgpOpciones;
        private RadioButton optDivision;
        private RadioButton optMultiplicacion;
        private RadioButton optResta;
        private RadioButton optSuma;
        private Label lblRespuesta;
        private RadioButton optRaiz;
        private RadioButton optPorcentaje;
        private RadioButton optExponente;
    }
}
