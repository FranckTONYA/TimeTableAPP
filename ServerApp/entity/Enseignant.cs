using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Enseignant
    {
        public Enseignant()
        {
            Programme = new HashSet<Programme>();
        }

        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [JsonIgnore]
        public ICollection<Programme> Programme { get; set; }
    }
}
