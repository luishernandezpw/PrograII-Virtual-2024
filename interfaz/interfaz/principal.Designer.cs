namespace interfaz {
    partial class principal {
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            numerosALetrasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            fibonacciToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            conversoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            salirToolStripMenuItem.Size = new Size(132, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { numerosALetrasToolStripMenuItem, toolStripMenuItem1, fibonacciToolStripMenuItem, toolStripMenuItem2, conversoresToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // numerosALetrasToolStripMenuItem
            // 
            numerosALetrasToolStripMenuItem.Name = "numerosALetrasToolStripMenuItem";
            numerosALetrasToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.N;
            numerosALetrasToolStripMenuItem.Size = new Size(205, 22);
            numerosALetrasToolStripMenuItem.Text = "Numeros a Letras";
            numerosALetrasToolStripMenuItem.Click += numerosALetrasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(202, 6);
            // 
            // fibonacciToolStripMenuItem
            // 
            fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            fibonacciToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            fibonacciToolStripMenuItem.Size = new Size(205, 22);
            fibonacciToolStripMenuItem.Text = "Fibonacci";
            fibonacciToolStripMenuItem.Click += fibonacciToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(202, 6);
            // 
            // conversoresToolStripMenuItem
            // 
            conversoresToolStripMenuItem.Name = "conversoresToolStripMenuItem";
            conversoresToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            conversoresToolStripMenuItem.Size = new Size(205, 22);
            conversoresToolStripMenuItem.Text = "Conversores";
            conversoresToolStripMenuItem.Click += conversoresToolStripMenuItem_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(691, 484);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "principal";
            Text = "Aplicacion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem numerosALetrasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem fibonacciToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem conversoresToolStripMenuItem;
    }
}