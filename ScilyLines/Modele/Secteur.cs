using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.Modele

{
    public class Secteur
    {

        private string name;
        private int id;
        private string nameport;
        private int idport;

        public Secteur(int id ,string name )
        {

            this.name = name;
            this.id = id;
               
        }
        

        public Secteur()
        {
            //
        }

        public string afficherSecteur
        {
            get => this.name;
        }
       

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        


    }
}