using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz {
    public partial class principal : Form {
        public principal() {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void numerosALetrasToolStripMenuItem_Click(object sender, EventArgs e) {
            Form1 objNumeros = new Form1();
            objNumeros.MdiParent = this;
            objNumeros.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e) {
            fibonacci objf = new fibonacci();
            objf.MdiParent = this;
            objf.Show();
        }

        private void conversoresToolStripMenuItem_Click(object sender, EventArgs e) {
            conversores obj = new conversores();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
