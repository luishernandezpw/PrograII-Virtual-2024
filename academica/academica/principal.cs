﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica {
    public partial class principal : Form {
        public principal() {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e) {
            alumnos obj = new alumnos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e) {
            materias obj = new materias();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
