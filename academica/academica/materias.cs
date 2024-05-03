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
    public partial class materias : Form {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        String accion = "nuevo";

        public materias() {
            InitializeComponent();
        }

        private void materias_Load(object sender, EventArgs e) {
            actualizarDsMaterias();
            grdDatosMateria.DataSource = dt.DefaultView;
        }
        private void actualizarDsMaterias() {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["materias"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idMateria"] };
            mostrarDatosMaterias();
        }
        private void mostrarDatosMaterias() {
            if (dt.Rows.Count > 0) {
                txtCodigoMateria.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtNombreMateria.Text = dt.Rows[posicion].ItemArray[2].ToString();
                txtUvMateria.Text = dt.Rows[posicion].ItemArray[3].ToString();

                lblNRegistroMateria.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                limpiarCajas();
            }
        }
        private void limpiarCajas() {
            txtCodigoMateria.Text = "";
            txtNombreMateria.Text = "";
            txtUvMateria.Text = "";
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e) {
            
        }
        private void activarDesactivarControles(Boolean estado) {
            grbDatosMateria.Enabled = !estado;
            grbNavegacionMateria.Enabled = estado;
            btnEliminarMateria.Enabled = estado;
        }
        private void filtrarDatosMaterias(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdDatosMateria.DataSource;
            bs.Filter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%' ";
            grdDatosMateria.DataSource = bs;
        }
        private void seleccionarMateria() {
            int _idMateria = int.Parse(grdDatosMateria.CurrentRow.Cells["idMateria"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(_idMateria));
            mostrarDatosMaterias();
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e) {
            if (posicion < dt.Rows.Count - 1) {
                posicion++;
                mostrarDatosMaterias();
            } else {
                MessageBox.Show("Ultimo Registro", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e) {
            posicion = dt.Rows.Count - 1;
            mostrarDatosMaterias();
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                mostrarDatosMaterias();
            } else {
                MessageBox.Show("Primer Registro", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e) {
            posicion = 0;
            mostrarDatosMaterias();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e) {
            if (btnAgregarMateria.Text == "Agregar") {//Nuevo
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                activarDesactivarControles(false);
                limpiarCajas();
                accion = "nuevo";
            } else {//Guardar
                String[] materias = new string[] {
                    dt.Rows[posicion].ItemArray[0].ToString(), //idAlumno
                    txtCodigoMateria.Text,
                    txtNombreMateria.Text,
                    txtUvMateria.Text
                };
                String resp = objConexion.administrarMaterias(materias, accion);
                if (resp != "1") {
                    MessageBox.Show("Error al intentar guardar: " + resp, "Edicion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    actualizarDsMaterias();
                    activarDesactivarControles(true);
                    btnAgregarMateria.Text = "Agregar";
                    btnModificarMateria.Text = "Modificar";
                }
            }
        }

        private void btnModificarMateria_Click(object sender, EventArgs e) {
            if (btnModificarMateria.Text == "Modificar") {//Modificar
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                activarDesactivarControles(false);
                accion = "modificar";
            } else {//Cancelar
                mostrarDatosMaterias();
                activarDesactivarControles(true);
                btnAgregarMateria.Text = "Agregar";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta Segurod de eliminar: " + txtNombreMateria.Text, "Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                String resp = objConexion.administrarMaterias(new string[] {
                    dt.Rows[posicion].ItemArray[0].ToString()
                }, "eliminar");
                if (resp != "1") {
                    MessageBox.Show("Error al eliminar. " + resp, "Eliminando Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    actualizarDsMaterias();
                }
            }
        }

        private void txtBuscarMateria_TextChanged(object sender, EventArgs e) {
            filtrarDatosMaterias(txtBuscarMateria.Text);
        }

        private void grdDatosMateria_CellClick(object sender, DataGridViewCellEventArgs e) {
            seleccionarMateria();
        }

        private void txtBuscarMateria_KeyUp(object sender, KeyEventArgs e) {
            filtrarDatosMaterias(txtBuscarMateria.Text);
            if (e.KeyCode == Keys.Enter) {
                seleccionarMateria();
            }
        }
    }
}
