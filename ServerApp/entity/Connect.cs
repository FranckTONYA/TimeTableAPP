using System;
using System.Collections.Generic;

namespace ServerApp.entity
{
    public partial class Connect
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public DateTime ConnectTime { get; set; }
        public DateTime? DeconnectTime { get; set; }
    }
}
