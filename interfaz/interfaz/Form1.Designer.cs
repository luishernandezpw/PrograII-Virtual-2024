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
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaludo.Location = new Point(66, 65);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(173, 45);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 301);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Saludo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaludo;
    }
}
