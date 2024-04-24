namespace interfaz {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e) {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double respuesta = num1 + num2;
            MessageBox.Show("Respuesta: "+respuesta, "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
