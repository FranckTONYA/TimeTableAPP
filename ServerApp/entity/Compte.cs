using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Compte
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Passhash { get; set; }
        public string Email { get; set; }
        public string ImgSrc { get; set; }
        public int Profil { get; set; }
        public string ConfirmationToken { get; set; }
        public DateTime? ConfirmatedAt { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetAt { get; set; }
        public int? Status { get; set; }

        public Etudiant MatriculeNavigation { get; set; }
    }
}
