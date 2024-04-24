namespace interfaz {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e) {
            try {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double respuesta = 0;

                if (optSuma.Checked) {
                    respuesta = num1 + num2;
                } else if (optResta.Checked) {
                    respuesta = num1 - num2;
                } else if (optMultiplicacion.Checked) {
                    respuesta = num1 * num2;
                } else if (optDivision.Checked) {
                    respuesta = num1 / num2;
                }

                lblRespuesta.Text = "Respuesta: " + respuesta;
            }catch(Exception ex) {
                MessageBox.Show("Error, por favor ingreso los valores solicitados", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
