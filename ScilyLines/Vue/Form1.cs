using ScilyLines.Controleur;
using ScilyLines.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScilyLines.Modele;
using System.Data.SqlClient;
using System.Collections;

namespace ScilyLines

{
    public partial class Form1 : Form
    {
        SecLai sec;
        List<Secteur> lSec = new List<Secteur>();
        List<Laison> lLai= new List<Laison>();
        Secteur s;
        public Form1()
        {
            InitializeComponent();
            sec = new SecLai();
            s = new Secteur();
        }
        

        private void Form1_Load_1(object sender, EventArgs e)
        {

            lSec = sec.chargementSecBD();
            


            affiche();
        }
        public void affiche()

        {
            try
            {
                
                secteur.DataSource = null;
                secteur.DataSource = lSec;
                secteur.DisplayMember = "afficherSecteur";

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
                laison.DataSource = null;
                laison.DataSource = lLai;
                laison.DisplayMember = "afficherLaison";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void secteur_MouseClick(object sender, MouseEventArgs e)
        {
            int id =(secteur.SelectedIndex)+1;
            
            
            string name = secteur.GetItemText(secteur.SelectedItem);


            lLai = sec.chargementLaiBD(Convert.ToString(id) , name);
            affiche2();
            
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            duree.Visible = true;
            update.Visible = true;
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {


                Laison le = (Laison)laison.SelectedItem;

                le.Duree = duree.Text;
                int id = (secteur.SelectedIndex) + 1;


                string name = secteur.GetItemText(secteur.SelectedItem);

                sec.updateDuree(le , Convert.ToString(id), name );


                


                lLai = sec.chargementLaiBD(Convert.ToString(id), name);
               

                affiche2();
                MessageBox.Show("la duree est bien modifier vers : "+duree.Text+" min .");
                update.Visible = false;
                duree.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
