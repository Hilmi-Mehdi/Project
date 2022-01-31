using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabinet
{
    public class RDV
    {
        private int num_rdv;
        private String date_rdv;
        private String heure_rdv;
        private String val_rdv;

        public int Num_rdv { get => num_rdv; set => num_rdv = value; }
        public string Date_rdv { get => date_rdv; set => date_rdv = value; }
        public string Heure_rdv { get => heure_rdv; set => heure_rdv = value; }
        public string Val_rdv { get => val_rdv; set => val_rdv = value; }

        public RDV(int num_rdv,String date_rdv,String heure_rdv,String val_rdv)
        {
            this.num_rdv = num_rdv;
            this.date_rdv = date_rdv;
            this.heure_rdv = heure_rdv;
            this.val_rdv = val_rdv;
        }

        public void ajouter() { }
        public void afficher() { }
        public void modifier() { }
        public void supprimer() { }
    }

}