﻿using MySql.Data.MySqlClient;
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

        private static string dataBase = "scilylinees";

        private static string uid = "abder";

        private static string mdp = "abder";



        private static Connexion maConnexionSql;


        private static MySqlCommand com;
        public static List<Secteur> getSecteur()
        {

            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                com = maConnexionSql.reqExec("Select * from secteur ");


                MySqlDataReader reader = com.ExecuteReader();

                Secteur e;

                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    




                    e = new Secteur(id, nom );


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