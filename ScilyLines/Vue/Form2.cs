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

namespace ScilyLines.Vue
{
    public partial class Form2 : Form
    {
        SecLai sec;
        Connexion con;
        LaisonDAO l;
        List<Secteur> lSec = new List<Secteur>();
        List<Laison> lLai = new List<Laison>();
        Secteur s;


        public Form2()
        {
            InitializeComponent();
            sec = new SecLai();
            s = new Secteur();


        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string id_depart = id_sec.Text;
            string id_arrivee = arv.Text;
            string dure = duree.Text;
            string id_regroupe = id_sec.Text;
            LaisonDAO.addLiaison(dure,id_depart, id_arrivee,  id_regroupe);

            Form2 f = new Form2();
            f.Close();
            
        }
    } 

}
