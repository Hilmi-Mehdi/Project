using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabinet
{
    public class Patient
    {
        private int num;
        private String nom;
        private String prenom;
        private String date_de_naiss;
        private String sex;
        private String adder;
        private int num_tele;
        private String adresse;
        private int code_apci;

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Date_de_naiss { get => date_de_naiss; set => date_de_naiss = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Adder { get => adder; set => adder = value; }
        public int Num_tele { get => num_tele; set => num_tele = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Code_apci { get => code_apci; set => code_apci = value; }

        public Patient(int num,String n,String p , String d,String s ,String adder,int t,String a,int code_apci)
        {
            this.num = num;
            this.nom = n;
            this.prenom = p;
            this.date_de_naiss = d;
            this.sex = s;
            this.adder = adder;
            this.num_tele = t;
            this.adresse = a;
            this.code_apci = code_apci;
        }
        public void ajouter() { }
        public void modifier() { }
        public void supprimer() { }
    }
}