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
        private string id;

        public Secteur(string name, string id)
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
        public string Id { get => id; }
        public string Name { get => name; set => name = value; }


    }
}