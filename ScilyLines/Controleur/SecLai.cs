using ScilyLines.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScilyLines.Modele;

namespace ScilyLines.Controleur
{
    public class SecLai
    {
        SecteurDAO laiDAO = new SecteurDAO();
        List <Secteur> listeSecteur;

        public SecLai()
        {
            listeSecteur = new List<Secteur>();

        }
        // get secteur list
        public List<Secteur> chargementSecBD()
        {
            listeSecteur = SecteurDAO.getSecteur();
            return listeSecteur;
        }

    }
}
