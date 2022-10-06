﻿using ScilyLines.DAL;
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
        public List<Laison> chargementLaiBD()
        {
            listeLaison = LaisonDAO.getLaison();
            return listeLaison;
        }

    }
}
