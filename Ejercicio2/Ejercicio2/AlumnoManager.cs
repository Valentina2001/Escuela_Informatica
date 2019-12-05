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
                    cmd.CommandText = "SELECT num_matricula, dni, nombre FROM alumno";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            alumnos.Add(new Alumno()
                            {
                                Num_Matricula = Convert.ToInt32(dr["num_matricula"]),
                                Dni = Convert.ToInt32(dr["dni"]),
                                Nombre = dr["nombre"].ToString(),
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
                using (IDbTransaction trx = conn.BeginTransaction())
                {
                    try
                    {
                        using (IDbCommand cmd = conn.CreateCommand())
                        {
                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO alumno(dni, nombre) VALUES (@Dni, @Nombre)";

                            CreateParameter(cmd, "dni", alumno.Dni);
                            CreateParameter(cmd, "nombre", alumno.Nombre);

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

        public void Update(Alumno alumno)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Alumno SET dni=@Dni, nombre=@Nombre WHERE num_matricula=@Num_Matricula";

                    CreateParameter(cmd, "Num_Matricula", alumno.Num_Matricula);
                    CreateParameter(cmd, "Dni", alumno.Dni);
                    CreateParameter(cmd, "Nombre", alumno.Nombre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Num_Matricula)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Alumno WHERE num_matricula=@Num_Matricula";
                    CreateParameter(cmd, "num_matricula", Num_Matricula);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
