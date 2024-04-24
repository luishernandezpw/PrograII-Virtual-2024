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
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(18, 119);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(215, 45);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnSaludo_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(78, 36);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(78, 23);
            txtNum1.TabIndex = 1;
            // 
            // llbNum1
            // 
            llbNum1.AutoSize = true;
            llbNum1.Location = new Point(18, 39);
            llbNum1.Name = "llbNum1";
            llbNum1.Size = new Size(46, 15);
            llbNum1.TabIndex = 2;
            llbNum1.Text = "Num 1:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(18, 79);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(46, 15);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Num 2:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(78, 76);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(78, 23);
            txtNum2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 253);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(llbNum1);
            Controls.Add(txtNum1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtNum1;
        private Label llbNum1;
        private Label lblNum2;
        private TextBox txtNum2;
    }
}
