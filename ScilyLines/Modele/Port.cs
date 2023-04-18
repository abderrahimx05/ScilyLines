using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.Modele
{
    internal class Port
    {
        private string porte;
        private int id;
        

        public Port(int id, string porte)
        {

            this.porte = porte;
            this.id = id;

        }

      

        public string afficherPorte
        {
            get => this.porte;
        }
        

        public int Id { get => id; }
        public string Porte { get => porte; set => porte = value; }
    }
}
