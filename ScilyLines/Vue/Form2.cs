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

                portDepart.DataSource = null;
                portDepart.DataSource = lSec;
                portDepart.DisplayMember = "afficherSecteur";

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
        private void portDepart_Click(object sender, EventArgs e)
        {
           
          
            lSec = sec.chargementSecBD();
            affiche1();

        }
        private void portArrivee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((portDepart.SelectedIndex) + 1);

            lPorte = sec.chargementPoBD(id);
            affiche2();

        }
        private void ajouter_Click(object sender, EventArgs e)
            
        {
            int id_depart = (portDepart.SelectedIndex) + 1;
            


            int id_arrivee =(portArrivee.SelectedIndex) + 1;



            string dure = duree.Text;

           
           MessageBox.Show(Convert.ToString(id_depart), Convert.ToString(id_arrivee));

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
                
            }
      else
                {
                    
                    LaisonDAO.addLiaison( id_depart, id_arrivee,dure);
                this.Close();
                    
                    
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

       
    }

}