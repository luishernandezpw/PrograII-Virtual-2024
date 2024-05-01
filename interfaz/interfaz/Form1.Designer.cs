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
            txtNum = new TextBox();
            llbNum = new Label();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(42, 155);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(215, 45);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnSaludo_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(105, 43);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(92, 23);
            txtNum.TabIndex = 1;
            // 
            // llbNum
            // 
            llbNum.AutoSize = true;
            llbNum.Font = new Font("Segoe UI", 14.25F);
            llbNum.Location = new Point(42, 38);
            llbNum.Name = "llbNum";
            llbNum.Size = new Size(57, 25);
            llbNum.TabIndex = 2;
            llbNum.Text = "Num:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(42, 100);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(132, 22);
            lblRespuesta.TabIndex = 6;
            lblRespuesta.Text = "Respuesta: ?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 234);
            Controls.Add(lblRespuesta);
            Controls.Add(llbNum);
            Controls.Add(txtNum);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Convertir en Letras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNum;
        private Label llbNum;
        private Label lblRespuesta;
    }
}
