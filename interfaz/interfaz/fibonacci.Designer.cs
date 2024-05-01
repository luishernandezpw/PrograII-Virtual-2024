namespace interfaz {
    partial class fibonacci {
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
            lblhasta = new Label();
            txthasta = new TextBox();
            ltsSecuencia = new ListBox();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // lblhasta
            // 
            lblhasta.AutoSize = true;
            lblhasta.Location = new Point(49, 42);
            lblhasta.Name = "lblhasta";
            lblhasta.Size = new Size(46, 15);
            lblhasta.TabIndex = 0;
            lblhasta.Text = "HASTA:";
            // 
            // txthasta
            // 
            txthasta.Location = new Point(101, 39);
            txthasta.Name = "txthasta";
            txthasta.Size = new Size(260, 23);
            txthasta.TabIndex = 1;
            // 
            // ltsSecuencia
            // 
            ltsSecuencia.FormattingEnabled = true;
            ltsSecuencia.ItemHeight = 15;
            ltsSecuencia.Location = new Point(49, 89);
            ltsSecuencia.Name = "ltsSecuencia";
            ltsSecuencia.Size = new Size(312, 229);
            ltsSecuencia.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(386, 89);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(141, 50);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // fibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 335);
            Controls.Add(btnGenerar);
            Controls.Add(ltsSecuencia);
            Controls.Add(txthasta);
            Controls.Add(lblhasta);
            Name = "fibonacci";
            Text = "Secuencia Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhasta;
        private TextBox txthasta;
        private ListBox ltsSecuencia;
        private Button btnGenerar;
    }
}