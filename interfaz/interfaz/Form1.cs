namespace interfaz {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e) {
            String nombre = txtNombre.Text;

            MessageBox.Show("Hola "+nombre, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
