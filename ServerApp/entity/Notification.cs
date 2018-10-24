using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Sms { get; set; }

        public Etudiant MatriculeNavigation { get; set; }
    }
}
