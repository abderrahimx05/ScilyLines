using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.DAL
{
    internal class LaisonDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "scilyline";

        private static string uid = "scilyline";

        private static string mdp = "AbderBen22";



        private static Connexion maConnexionSql;

        private  Secteur s;
        
        private static MySqlCommand com;


        public static List<Laison> getLaison(string id , string name)
        {
             
            List<Laison> lc = new List<Laison>();
              

           
            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();
                // il faut donc que je cherche comment integre la labbele de secteur et id ;
               
                    com = maConnexionSql.reqExec("Select  LIBELLE , NOM , duree from  secteur S  ,port P  , liaison L where   P.ID=L.ID_ARRIVEE and S.LIBELLE='"+name+"' and L.ID_REGROUPER="+id);
                    
                

                MySqlDataReader reader = com.ExecuteReader();

                Laison e;

                while (reader.Read())
                {
                    string arrivee = (string)reader.GetValue(1);
                    string depart = (string)reader.GetValue(0);
                    string duree = (string)reader.GetValue(2);



                    e = new Laison( depart,arrivee , duree);
                    

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
        public static void updateDuree(Laison le)
        {

            try
            {


                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec("update employe set login= '" + le.Duree);


                int i = com.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

    }
}
