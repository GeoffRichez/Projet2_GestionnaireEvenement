using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum StatutDevis { Demande, EnCours, Valide }
    public class Devis
    {
        public int Id { get; set; }
        public Entreprise EntrepriseDevis { get; set; }
        public Evenement EventDevis { get; set; }
        public DateTime DateEmissionDevis { get; set; }
        public StatutDevis AvancementDevis { get; set; }
        public float CoutEstime { get; set; }

    }
}
