using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class GrupoManager
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
        public List<Grupo> GetGrupos()
        {
            List<Grupo> grupos = new List<Grupo>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT num_grupo, nombre, num_componente FROM grupo";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            grupos.Add(new Grupo()
                            {
                                Num_grupo = Convert.ToInt32(dr["num_grupo"]),
                                Nombre_grupo = dr["nombre"].ToString(),
                                Num_componente = Convert.ToInt32(dr["num_componente"])
                            });
                        }
                    }
                }
            }
            return grupos;
        }

        public void Write(Grupo grupo)
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
                            cmd.CommandText = "INSERT INTO grupo(nombre, num_componente) VALUES (@Nombre_grupo, @Num_componente)";
                            CreateParameter(cmd, "Nombre_grupo", grupo.Nombre_grupo);
                            CreateParameter(cmd, "Num_componente", grupo.Num_componente);

                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "INSERT INTO logs(action, createDate) VALUES(@action, @createDate)";
                            CreateParameter(cmd, "action", "New grupo created");
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

        public void Delete(int num_grupo)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM grupo WHERE num_grupo=@Num_grupo";
                    CreateParameter(cmd, "Num_grupo", num_grupo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Grupo grupo)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Grupo SET nombre=@Nombre_grupo, num_componente=@Num_componente WHERE num_grupo=@Num_grupo";

                    CreateParameter(cmd, "Num_grupo", grupo.Num_grupo);
                    CreateParameter(cmd, "Nombre_grupo", grupo.Nombre_grupo);
                    CreateParameter(cmd, "Num_componente", grupo.Num_componente);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
