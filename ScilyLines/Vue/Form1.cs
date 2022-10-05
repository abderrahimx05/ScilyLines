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
namespace ScilyLines

{
    public partial class Form1 : Form
    {
        SecLai sec;
        List<Secteur> lSec = new List<Secteur>();
        public Form1()
        {
            InitializeComponent();
            sec = new SecLai();
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
    }
}
