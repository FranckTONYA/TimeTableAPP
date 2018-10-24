using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Mention
    {
        public string Codmention { get; set; }
        public decimal Valeurmin { get; set; }
        public decimal Valeurmax { get; set; }
        public decimal? Qualitepoints { get; set; }
        public int Etat { get; set; }
    }
}
