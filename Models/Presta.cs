using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Presta
    {
        public int Id { get; set; }
        public Utilisateur PrestaUser { get; set; }
        public string Iban { get; set; }
        public string PrestationProposee { get; set; }
        public bool DispoPresta { get; set; }
        public int CapacitePrestation { get; set; }
    }
}
