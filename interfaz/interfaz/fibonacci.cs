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
    public partial class fibonacci : Form {
        public fibonacci() {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            int hasta = int.Parse(txthasta.Text);
            int a = 1, b = 0, c = 0;
            ltsSecuencia.Items.Clear();
            do {
                c = a + b;
                ltsSecuencia.Items.Add(a+"+"+b+"="+c);
                b = a;
                a = c;
            }while(c<hasta);
        }
    }
}
