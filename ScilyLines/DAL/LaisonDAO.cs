using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.DAL
{
    public class LaisonDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "scilyline";

        private static string uid = "scilyline";

        private static string mdp = "AbderBen22";



        private static Connexion maConnexionSql;

        

        private static MySqlCommand com;
        public static List<Laison> getLaison()
        {

            List<Laison> lc = new List<Laison>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                Secteur  s= new  Secteur();
                maConnexionSql.openConnection();

                com = maConnexionSql.reqExec("Select * from Liaison where ID_REGROUPER"+ s.Id);


                MySqlDataReader reader = com.ExecuteReader();

                Laison e;

                while (reader.Read())
                {
                    string ID = (string)reader.GetValue(0);
                    string depart = (string)reader.GetValue(1);
                    string arrivee = (string)reader.GetValue(2);
                    string duree = (string)reader.GetValue(4);



                    e = new Laison(ID , depart ,arrivee , duree);
                    

                    lc.Add(e);


                }






                reader.Close();

                maConnexionSql.closeConnection();


                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }

        }


    }
}
