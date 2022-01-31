using System;
using System.Collections.Generic;
using System.Text;

namespace projetEtu
{
    class Consultation
    {
        private int Num_cons;
        private DateTime date_cons;
        private char daig_cons;

        public int Num_cons1 { get => Num_cons; set => Num_cons = value; }
        public DateTime Date_cons { get => date_cons; set => date_cons = value; }
        public char Daig_cons { get => daig_cons; set => daig_cons = value; }

        public Consultation(int Num_cons, DateTime date_cons, char daig_cons)
        {
            this.Num_cons = Num_cons;
            this.date_cons = date_cons;
            this.daig_cons = daig_cons;
        }
        public string ajouter()
        {
            return 0;
        }
        public string modifier()
        {
            return 0;
        }
    }
}
