using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class AlumnoManager
    {
        private IDbConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Ejercicio2;Trusted_Connection=True;");
            conn.Open();
            return conn;
        }

        private void CreateParameter<T>(IDbCommand cmd, string name, T value)
        {
            IDbDataParameter prm = cmd.CreateParameter();
            prm.ParameterName = name;
            prm.Value = value;
            cmd.Parameters.Add(prm);
        } 

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT num_matricula, dni, nombre FROM Ejercicio2";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            alumnos.Add(new Alumno()
                            {
                                num_matricula = Convert.ToInt32(dr["num_matricula"]),
                                dni = Convert.ToInt32(dr["dni"]),
                                nombre = dr["nombre"].ToString(),
                            });
                        }
                    }
                }
            }
            return alumnos;
        }

        public void Write(Alumno alumno)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using(IDbTransaction trx = conn.BeginTransaction())
                {
                    try
                    {
                        using(IDbCommand cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = trx;
                            //ni idea
                            cmd.CommandText = "INSERT INTO alumno(num_matricula, dni, nombre) VALUES(@num_matricula, @dni, @nombre)";

                            CreateParameter(cmd, "num_matricula", alumno.num_matricula);
                            CreateParameter(cmd, "dni", alumno.dni);
                            CreateParameter(cmd, "nombre", alumno.nombre);

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO logs(action, createDate) VALUES(@action, @createDate)";
                            CreateParameter(cmd, "action", "New alumno created");
                            CreateParameter(cmd, "createDate", DateTime.Now);
                            cmd.ExecuteNonQuery(); 
                        }
                        trx.Commit();
                    }
                    catch
                    {
                        trx.Rollback();
                    }
                }
            }
        }
    }
}
