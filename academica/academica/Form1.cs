using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica {
    public partial class alumnos : Form {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        String accion = "nuevo";
        public alumnos() {
            InitializeComponent();
        }
        private void actualizarDsAlumnos() {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };
            mostrarDatosAlumnos();
        }
        private void mostrarDatosAlumnos() {
            if (dt.Rows.Count > 0) {
                txtCodigoAlumno.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumno.Text = dt.Rows[posicion].ItemArray[2].ToString();
                txtDireccionAlumno.Text = dt.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoAlumno.Text = dt.Rows[posicion].ItemArray[4].ToString();
                txtDuiAlumno.Text = dt.Rows[posicion].ItemArray[5].ToString();

                lblNRegistroAlumno.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                limpiarCajas();
            }
        }
        private void limpiarCajas() {
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
            txtDuiAlumno.Text = "";
        }
        private void alumnos_Load(object sender, EventArgs e) {
            actualizarDsAlumnos();
            grdDatosAlumno.DataSource = dt.DefaultView;
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e) {
            if (posicion < dt.Rows.Count - 1) {
                posicion++;
                mostrarDatosAlumnos();
            } else {
                MessageBox.Show("Ultimo Registro", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                mostrarDatosAlumnos();
            } else {
                MessageBox.Show("Primer Registro", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e) {
            posicion = dt.Rows.Count - 1;
            mostrarDatosAlumnos();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatosAlumnos();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e) {
            if (btnAgregarAlumno.Text == "Agregar") {//Nuevo
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                activarDesactivarControles(false);
                limpiarCajas();
                accion = "nuevo";
            } else {//Guardar
                String[] alumnos = new string[] {
                    dt.Rows[posicion].ItemArray[0].ToString(), //idAlumno
                    txtCodigoAlumno.Text,
                    txtNombreAlumno.Text,
                    txtDireccionAlumno.Text,
                    txtTelefonoAlumno.Text,
                    txtDuiAlumno.Text
                };
                String resp = objConexion.administrarAlumnos(alumnos, accion);
                if( resp!="1") {
                    MessageBox.Show("Error al intentar guardar: "+ resp, "Edicion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    actualizarDsAlumnos();
                    activarDesactivarControles(true);
                    btnAgregarAlumno.Text = "Agregar";
                    btnModificarAlumno.Text = "Modificar";
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e) {
            if (btnModificarAlumno.Text == "Modificar") {//Modificar
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                activarDesactivarControles(false);
                accion = "modificar";
            } else {//Cancelar
                mostrarDatosAlumnos();
                activarDesactivarControles(true);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }
        private void activarDesactivarControles(Boolean estado) {
            grbDatosAlumnos.Enabled = !estado;
            grbNavegacionAlumno.Enabled = estado;
            btnEliminarAlumno.Enabled=estado;
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e) {
            if( MessageBox.Show("Esta Segurod de eliminar: "+ txtNombreAlumno.Text, "Eliminar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {
                String resp = objConexion.administrarAlumnos(new string[] {
                    dt.Rows[posicion].ItemArray[0].ToString()
                }, "eliminar");
                if( resp!="1") {
                    MessageBox.Show("Error al eliminar. "+ resp, "Eliminando Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    actualizarDsAlumnos();
                }
            }
            
        }
        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e) {
            filtrarDatosAlumnos(txtBuscarAlumno.Text);
        }
        private void filtrarDatosAlumnos(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdDatosAlumno.DataSource;
            bs.Filter = "codigo like '%"+ valor +"%' OR nombre like '%"+ valor +"%' OR dui like '%"+ valor +"%' ";
            grdDatosAlumno.DataSource = bs;
        }
        private void seleccionarAlumno() {
            int _idAlumno = int.Parse(grdDatosAlumno.CurrentRow.Cells["idAlumno"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(_idAlumno));
            mostrarDatosAlumnos();
        }

        private void grdDatosAlumno_CellClick(object sender, DataGridViewCellEventArgs e) {
            seleccionarAlumno();
        }

        private void txtBuscarAlumno_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatosAlumnos(txtBuscarAlumno.Text);
            if( e.KeyCode==Keys.Enter) {
                seleccionarAlumno();
            }
        }
    }
}