using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities.Collections;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
               
                    com = maConnexionSql.reqExec("Select  LIBELLE , NOM , duree , ID_ARRIVEE from  secteur S  ,port P  , liaison L where   P.ID=L.ID_ARRIVEE and S.LIBELLE='"+name+"' and L.ID_REGROUPER="+id);
                    
                

                MySqlDataReader reader = com.ExecuteReader();

                Laison e;

                while (reader.Read())
                {
                    string arrivee = (string)reader.GetValue(1);
                    string depart = (string)reader.GetValue(0);
                    string duree = (string)reader.GetValue(2);
                    string arrive = (string)reader.GetValue(3);
                    



                    e = new Laison( depart,arrivee , duree , arrive);
                    

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
        public static void updateDuree(Laison le , string id , string name )
        {

            try
            {


                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec(" update liaison   set duree=" + le.Duree+ " where ID_REGROUPER="+id+" and  ID_ARRIVEE=" +le.ArriveeId);


                int i = com.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        public static void deleteLiaison(Laison le, string id, string name)
        {

            try
            {


                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec(" delete from liaison  where ID_REGROUPER="+id+" and  ID_ARRIVEE=" +le.ArriveeId);


                int i = com.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        public static void addLiaison(string duree, string id_depart, string id_arrivee , string id_secteur)
        {

            try
            {


                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();
                string req = "INSERT INTO liaison(ID_DEPART, ID_ARRIVEE , duree , ID_REGROUPER) VALUES(" + id_depart + ", " + id_arrivee + ", " + duree + ", " + id_secteur + ")";

                MessageBox.Show(req);
                
                com = maConnexionSql.reqExec("INSERT INTO liaison(ID_DEPART, ID_ARRIVEE , duree ,ID_REGROUPER) VALUES("+id_depart+","+ id_arrivee +","+duree+","+id_secteur+")");


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
