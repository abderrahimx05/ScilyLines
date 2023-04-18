using MySql.Data.MySqlClient;
using ScilyLines.Controleur;
using ScilyLines.DAL;
using ScilyLines.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ScilyLines.Vue
{
    public partial class Form2 : Form
    {
        SecLai sec;
        Connexion con;
        LaisonDAO l;
        List<Secteur> lSec = new List<Secteur>();
        List<Laison> lLai = new List<Laison>();
        List<Port> lPort = new List<Port>();
        List<Port> lPorte = new List<Port>();
        Secteur s;


        public Form2()
        {
            InitializeComponent();
            sec = new SecLai();
            s = new Secteur();


        }
        
        public void affiche1()

        {
            try
            {

                portArrivee.DataSource = null;
                portArrivee.DataSource = lPort;
                portArrivee.DisplayMember = "afficherPorte";

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void affiche2()

        {
            try
            {

                portArrivee.DataSource = null;
                portArrivee.DataSource = lPorte;
                portArrivee.DisplayMember = "afficherPorte";

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            string id_depart = portDepart.Text;


            string id_arrivee = portArrivee.Text;



            string dure = duree.Text;


            string id_regroupe = "aa";
            int id = 1;
            if ( portDepart.Text.Length == 0 || portArrivee.Text.Length == 0|| duree.Text.Length == 0 )
            {
                string message = "Vous n'avez pas entrer aucun valeur pour l'operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {

                    this.Show();




                }
                else
                {
                    LaisonDAO.addLiaison(id, dure, id_depart, id_arrivee, id_regroupe);
                    this.Close();
                }
            }
            
            
            
           

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        

        private void portDepart_Click(object sender, EventArgs e)
        {
            lPort = sec.chargementPoBD();
            affiche1();

        }
        private void portArrivee_Click(object sender, EventArgs e)
        {
            lPorte = sec.chargementPoBD();
            affiche1();

        }
    }

}