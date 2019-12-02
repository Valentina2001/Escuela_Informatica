using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ProfesorManager
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

        public List<Profesor> GetProfesor()
        {
            List<Profesor> profesores = new List<Profesor>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT dni, nombre, domicilio FROM profesor";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            profesores.Add(new Profesor()
                            {
                                DNI = Convert.ToInt32(dr["dni"]),
                                Nombre = dr["nombre"].ToString(),
                                Domicilio = dr["domicilio"].ToString(),
                            });
                        }
                    }
                }
            }
            return profesores;
        }

        public void Write(Profesor profesor)
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
                            //ni idea
                            cmd.CommandText = "INSERT INTO profesor(dni, nombre, domicilio) VALUES(@DNI, @Nombre, @Domicilio)";

                            CreateParameter(cmd, "dni", profesor.DNI);
                            CreateParameter(cmd, "nombre", profesor.Nombre);
                            CreateParameter(cmd, "domicilio", profesor.Domicilio);

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
