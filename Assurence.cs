using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabinet
{
    public class Assurence
    {
        private int num_mat_pat;
        private String type;
        private String date;

        public int Num_mat_pat { get => num_mat_pat; set => num_mat_pat = value; }
        public string Type { get => type; set => type = value; }
        public string Date { get => date; set => date = value; }

        public Assurence(int num_mat_pat,String type,String date)
        {
            this.num_mat_pat = num_mat_pat;
            this.type = type;
            this.date = date;
        }
        public void ajouter() { }
        public void imprimer() { }
        public void modifier() { }
        public void afficher() { }
    }
}