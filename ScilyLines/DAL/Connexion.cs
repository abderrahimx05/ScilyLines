using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.DAL
{
    internal class Connexion
    {
        private static Connexion connection = null;

        private MySqlConnection mysqlCn;

        private static readonly object mylock = new object();

        private string connString;


        private Connexion(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    mysqlCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }



        }



        //create a connexion 
        public static Connexion getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { 
                        connection = new Connexion(unProvider, uneDataBase, unUid, unMdp);

                    }

                }
                catch (Exception emp)
                {
                    throw (emp);


                }
                return connection;

            }
        }





        // to open the connexion 
        public void openConnection()
        {
            try
            {
                mysqlCn.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        // to close the c
        public void closeConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close();
        }

        //Exécutiuon d'une requête
          
         
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn);
            return (mysqlCom);
        }


        
       

    }
}
