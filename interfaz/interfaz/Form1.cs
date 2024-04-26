namespace interfaz {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e) {
            try {
                String unidadesLetras = "", decenasLetras = "", respuesta = "";

                String[] unidades = {"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
                String[] especiales = {"", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE","",
                    "VEINTIUNO", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE"};
                String[] decenas = {"", "DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };

                String num = txtNum.Text.Trim();

                if (num.Length <= 1) {
                    respuesta = unidades[int.Parse(num)];
                }
                if (int.Parse(num) > 10 && int.Parse(num) < 30 && int.Parse(num) != 20) {
                    respuesta = especiales[int.Parse(num) - 10];
                }
                if (num.Length <= 2 && int.Parse(num) >= 30 || int.Parse(num)==20) {
                    int decena = int.Parse(num.Substring(0,1));
                    int uni = int.Parse(num.Substring(1, 1));

                    unidadesLetras = unidades[uni];
                    decenasLetras = decenas[decena];
                    if (unidadesLetras != "CERO") {
                        respuesta = decenasLetras + " y " + unidadesLetras;
                    } else {
                        respuesta = decenasLetras;
                    }
                }
                lblRespuesta.Text = "Respuesta: " + respuesta;
            }catch(Exception ex) {
                MessageBox.Show("Error, por favor ingreso los valores solicitados", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
