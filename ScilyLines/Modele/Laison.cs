using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScilyLines.Modele
{
    public class Laison
    {
        private string id;
        private string depart;
        private string arrivee;
        private string duree;
        private string arriveeId;





        public Laison( string depart ,string arrivee , string duree , string arriveeId)
        {
            this.id = id;
            this.depart = depart;
            this.arrivee = arrivee;
            this.duree = duree; 
            this.ArriveeId=arriveeId;
        }

        public Laison()
        {
            //
        }




        public string afficherLaison
        {
            get =>"Depart: "+this.depart+ " Vers : "+this.arrivee+" d'une duree de : "+this.duree+" min .";
        }
        private string Id { get => id; }
        public string Depart { get => depart; set => depart = value; }
        public string Arrivee { get => arrivee; set => arrivee = value; }
        public string Duree { get => duree; set => duree = value; }
        public string ArriveeId { get => arriveeId; set => arriveeId = value; }
    }
}
