using System;
using System.Collections.Generic;
using System.Text;

namespace projetEtu
{
    class Ordonnonce
    {
        private int Num_ordonn;
        private DateTime Date_ordonn;
        private char Nom_medc;
        private char Form_medc;

        public int Num_ordonn1 { get => Num_ordonn; set => Num_ordonn = value; }
        public DateTime Date_ordonn1 { get => Date_ordonn; set => Date_ordonn = value; }
        public char Nom_medc1 { get => Nom_medc; set => Nom_medc = value; }
        public char Form_medc1 { get => Form_medc; set => Form_medc = value; }

        public Ordonnonce(int Num_ordonn, DateTime Date_ordonn, char Nom_medc, char Form_medc)
        {
            this.Num_ordonn = Num_ordonn;
            this.Date_ordonn = Date_ordonn;
            this.Nom_medc = Nom_medc;
            this.Form_medc = Form_medc;
        }
        public string afficher()
        {
            return 0;
        }
        public string etablier()
        {
            return 0;
        }
        public string imprimer()
        {
            return 0;
        }
    }
}
