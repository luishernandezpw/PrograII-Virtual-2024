namespace interfaz {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e) {
            MessageBox.Show("hola, que tal, chicos de Progra II", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
