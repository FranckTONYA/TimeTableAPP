using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            Compte = new HashSet<Compte>();
            Inscrit = new HashSet<Inscrit>();
            Moyennes = new HashSet<Moyennes>();
            Notes = new HashSet<Notes>();
            Notification = new HashSet<Notification>();
            Resultat = new HashSet<Resultat>();
        }

        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }
        public string Pere { get; set; }
        public string Mere { get; set; }
        public string Adresse { get; set; }
        public string Datenaissance { get; set; }
        public string Codnat { get; set; }
        public string Codprovince { get; set; }
        public string Villenaissance { get; set; }
        public string Diplome { get; set; }
        public int? Session { get; set; }
        public DateTime? Dateins { get; set; }
        public string Langue { get; set; }
        public int? Refugie { get; set; }
        public int? Handicape { get; set; }
        public string Telephone { get; set; }
        public int? AccessFailedCount { get; set; }

        public Nationalite CodnatNavigation { get; set; }
        public Province CodprovinceNavigation { get; set; }
        public ICollection<Compte> Compte { get; set; }
        public ICollection<Inscrit> Inscrit { get; set; }
        public ICollection<Moyennes> Moyennes { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<Resultat> Resultat { get; set; }
    }
}
