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
        LaisonDAO laDAO = new LaisonDAO();
        List<Laison> listeLaison;
        Secteur s;

        public SecLai()
        {
            listeSecteur = new List<Secteur>();
            listeLaison = new List<Laison>();

        }
        // get secteur list
        public List<Secteur> chargementSecBD()
        {
            listeSecteur = SecteurDAO.getSecteur();
            return listeSecteur;
        }
        public List<Laison> chargementLaiBD(string id , string name)
        {
             listeLaison = LaisonDAO.getLaison(id, name);
            return listeLaison;
        }
        public void updateDuree(Laison le , string id , string name)
        {

            LaisonDAO.updateDuree(le , id , name );

        }

    }
}
