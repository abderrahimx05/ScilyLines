using ScilyLines.Controleur;
using ScilyLines.DAL;
using ScilyLines.Vue;
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
            
            delete.Visible = true;
            modifier.Visible = true;
            
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            duree.Visible = true;
            update.Visible = true;
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            update.BackColor = Color.Red;
            
            try
            {
                


                if (duree.Text.Length == 0)
                {
                    // si l'utilisateur il a rien entre dans textBon
                    string message = "Vous n'avez pas entrer aucun valeur pour l'operation?";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {

                        this.Refresh();
                        
                        

                    }
                }
                else
                {
 DialogResult dialogResult = MessageBox.Show("vous êtes sûr ?", "Modifier la durée", MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
                {
                    Laison le = (Laison)laison.SelectedItem;
                    le.Duree = duree.Text;
                    int id = (secteur.SelectedIndex) + 1;


                    string name = secteur.GetItemText(secteur.SelectedItem);

                    
                      sec.updateDuree(le, Convert.ToString(id), name);
                      lLai = sec.chargementLaiBD(Convert.ToString(id), name);


                    affiche2();
                    MessageBox.Show("la duree est bien modifier vers : " + duree.Text + " min .");

                }
                else if (dialogResult == DialogResult.No)
                {
                    int id = (secteur.SelectedIndex) + 1;


                    string name = secteur.GetItemText(secteur.SelectedItem);

                    lLai = sec.chargementLaiBD(Convert.ToString(id), name);
                } 
                }
                
                
               

               
               

                
                update.Visible = false;
                duree.Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            





            
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            Laison le = (Laison)laison.SelectedItem;

            le.Duree = duree.Text;
            int id = (secteur.SelectedIndex) + 1;


            string name = secteur.GetItemText(secteur.SelectedItem);


            DialogResult dialogResult = MessageBox.Show("vous êtes sûr ?", "Supprimer la liaison", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sec.deleteLiaison(le, Convert.ToString(id), name);
                this.Refresh();
                lLai = sec.chargementLaiBD(Convert.ToString(id), name);
                affiche2();
                
                
            }
            else if (dialogResult == DialogResult.No)
            {
                lLai = sec.chargementLaiBD(Convert.ToString(id), name);
            }
        }

        private void inserer_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
