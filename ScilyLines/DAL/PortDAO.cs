using MySql.Data.MySqlClient;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.DAL
{
    internal class PortDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "scilylinees";

        private static string uid = "abder";

        private static string mdp = "abder";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;
        public static List<Port> getPort()
        {

            List<Port> dor = new List<Port>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec("Select * from port ");


                MySqlDataReader reader = com.ExecuteReader();

                Port e;

                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);





                    e = new Port(id, nom);


                    dor.Add(e);


                }

                reader.Close();

                maConnexionSql.closeConnection();


                return (dor);



            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }
    }
}
