using MySql.Data.MySqlClient;
using ScilyLines.DAL;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines
{
    public class SecteurDAO
    {

        private static string provider = "localhost";

        private static string dataBase = "scilyline";

        private static string uid = "scilyline";

        private static string mdp = "AbderBen22";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;
        public static List<Secteur> getSecteur()
        {

            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = com.ExecuteReader();

                Secteur e;

              while (reader.Read())
                {

                    
                    string nom = (string)reader.GetValue(1);
                   

                  
                    e = new Secteur(nom);

                   
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