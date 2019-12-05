using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class TfcManager
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

        public List<TFC> GetTfc()
        {
            List<TFC> tfc = new List<TFC>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT num_orden, tema, fecha FROM TFC";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tfc.Add(new TFC()
                            {
                                Num_orden = Convert.ToInt32(dr["num_orden"]),
                                Tema = dr["tema"].ToString(),
                                Fecha = dr["fecha"].ToString(),
                            });
                        }
                    }
                }
            }
            return tfc;
        }

        public void Write(TFC tfc)
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

                            cmd.CommandText = "INSERT INTO TFC(tema, fecha) VALUES(@Tema, @Fecha)";

                            CreateParameter(cmd, "tema", tfc.Tema);
                            CreateParameter(cmd, "fecha", tfc.Fecha);

                            cmd.ExecuteNonQuery();

                            cmd.CommandText = "INSERT INTO logs(action, createDate) VALUES(@action, @createDate)";
                            CreateParameter(cmd, "action", "New TFC created");
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

        public void Update(TFC tfc)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE TFC SET tema=@Tema, fecha=@Fecha WHERE num_orden=@Num_orden";

                    CreateParameter(cmd, "num_orden", tfc.Num_orden);
                    CreateParameter(cmd, "tema", tfc.Tema);
                    CreateParameter(cmd, "fecha", tfc.Fecha);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Num_Orden)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM TFC WHERE num_orden=@Num_orden";
                    CreateParameter(cmd, "num_orden", Num_Orden);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
