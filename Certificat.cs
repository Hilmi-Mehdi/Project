using System;
using System.Collections.Generic;
using System.Text;

namespace projetEtu
{
    class Certificat
    {
        private int Num_cart;
        private DateTime Date_cart;
        private string com_cart;
        private int nom_jour;

        public int Num_cart1 { get => Num_cart; set => Num_cart = value; }
        public string Com_cart { get => com_cart; set => com_cart = value; }
        public DateTime Date_cart1 { get => Date_cart; set => Date_cart = value; }
        public int Nom_jour { get => nom_jour; set => nom_jour = value; }

        public Certificat(int Num_cart, DateTime Date_cart, string com_cart, int nom_jour)
        {
            this.Num_cart = Num_cart;
            this.Date_cart = Date_cart;
            this.com_cart = com_cart;
            this.nom_jour = nom_jour;
        }
        public int etablir()
        {
            return 0;
        }
        public int modifier()
        {
            return 0;
        }
        public int imprime()
        {
            return 0;
        }
    }
}
