using ScilyLines.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScilyLines.Modele;
using System.Xml.Linq;

namespace ScilyLines.Controleur
{
    internal class SecLai
    {
        SecteurDAO laiDAO = new SecteurDAO();
        List<Secteur> listeSecteur;
        LaisonDAO laDAO = new LaisonDAO();
        List<Laison> listeLaison;
        PortDAO laiPort = new PortDAO();
        List<Port> listePorte;
        Secteur s;

        public SecLai()
        {
            listeSecteur = new List<Secteur>();
            listeLaison = new List<Laison>();
            listePorte = new List<Port>();

        }
        // get secteur list
        public List<Secteur> chargementSecBD()
        {
            listeSecteur = SecteurDAO.getSecteur();
            return listeSecteur;
        }
        //to get list port
        public   List <Port> chargementPoBD()
        {
            listePorte = PortDAO.getPort();
            return listePorte;
        }
       

        public List<Laison> chargementLaiBD(int id, string name)
        {
            listeLaison = LaisonDAO.getLaison(id, name);
            return listeLaison;
        }
        public void updateDuree(Laison le, int id, string name)
        {

            LaisonDAO.updateDuree(le, id, name);

        }
        public void deleteLiaison(Laison le, int id, string name)
        {

            LaisonDAO.deleteLiaison(le, id, name);

        }



    }
}