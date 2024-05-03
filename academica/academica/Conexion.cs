using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria para obtener todos los objetos de conexion a la BD
using System.Data.SqlClient; //Proveedor de datos Sql Server.

namespace academica {
    internal class Conexion {
        SqlConnection miConexion = new SqlConnection(); //Conexion a la BD
        SqlCommand miComando = new SqlCommand();//ejecutar sentencias SQL en la BD
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //intermediario entre la BD y la aplicacion
        DataSet ds = new DataSet(); //Copia de la arquitectura de la BD en memoria.

        public Conexion() {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtenerDatos() {
            ds.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from alumnos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "alumnos");

            miComando.CommandText = "select * from materias";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "materias");

            return ds;
        }
        public String administrarAlumnos(String[] alumnos, String accion) {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO alumnos (codigo,nombre,direccion,telefono,dui) VALUES('"+ alumnos[1] +"'," +
                    "'"+ alumnos[2] +"', '"+ alumnos[3] +"', '"+ alumnos[4] +"', '"+ alumnos[5] +"')";
            }else if (accion == "modificar") {
                sql = "UPDATE alumnos SET codigo='" + alumnos[1] + "'," +
                    "nombre='" + alumnos[2] + "', direccion='" + alumnos[3] + "', telefono='" + alumnos[4] + "', dui='" + alumnos[5] + "'" +
                    "WHERE idAlumno='"+ alumnos[0] +"'";
            }else if (accion == "eliminar") {
                sql = "DELETE alumnos WHERE idAlumno='" + alumnos[0] + "'";
            }
            return ejecutarSql(sql);
        }
        public String administrarMaterias(String[] materias, String accion) {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO materias (codigo,nombre,uv) VALUES('" + materias[1] + "'," +
                    "'" + materias[2] + "', '" + materias[3] + "')";
            } else if (accion == "modificar") {
                sql = "UPDATE materias SET codigo='" + materias[1] + "'," +
                    "nombre='" + materias[2] + "', uv='" + materias[3] + "'" +
                    "WHERE idMateria='" + materias[0] + "'";
            } else if (accion == "eliminar") {
                sql = "DELETE materias WHERE idMateria='" + materias[0] + "'";
            }
            return ejecutarSql(sql);
        }
        private String ejecutarSql(String sql) {
            try {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }catch (Exception ex) {
                return ex.Message;
            }
           
        }
    }
}
