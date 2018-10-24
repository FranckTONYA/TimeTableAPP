using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Filiere
    {
        public Filiere()
        {
            Classe = new HashSet<Classe>();
            Specialite = new HashSet<Specialite>();
            Ue = new HashSet<Ue>();
        }

        public int Idfiliere { get; set; }
        public string Codfiliere { get; set; }
        public string Nom { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Classe> Classe { get; set; }
        public ICollection<Specialite> Specialite { get; set; }
        public ICollection<Ue> Ue { get; set; }
    }
}
