using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.Modele

{
    public class Secteur
    {
        
        private  string name;





        public Secteur( string name)
        {
            
            this.name = name;
        } 

        public Secteur()
        {
            //
        }
        
        
        

        public string afficherSecteur
        {
            get =>  this.name;
        }
    public string Name { get => name; set => name = value; }
    }
}
