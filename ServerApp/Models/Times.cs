using ServerApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class Times
    {
        public int Id { get; set; }
        public Jour IdjourNavigation { get; set; }
        public Periode IdperiodeNavigation { get; set; }
        public Programme IdprogrammeNavigation { get; set; }
        public Salle IdsalleNavigation { get; set; }
    }
}
