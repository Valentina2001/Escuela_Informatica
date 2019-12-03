using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class TribunalManager
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

        public List<Tribunal> GetTribunales()
        {
            List<Tribunal> tribunales = new List<Tribunal>();
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT num, lugar_examen, num_componentes FROM Ejercicio2";
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tribunales.Add(new Tribunal()
                            {
                                Num = Convert.ToInt32(dr["num"]),
                                Lugar_Examen = dr["lugar_examen"].ToString(),
                                Num_Componentes = Convert.ToInt32(dr["num_componentes"]),
                            });
                        }
                    }
                }
            }
            return tribunales;
        }
    }
}
