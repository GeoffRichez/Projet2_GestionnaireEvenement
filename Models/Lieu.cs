using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum TypeLieu { Lieu_Entreprise, Lieu_Prestataire}
    public class Lieu
    {
        public int Id { get; set; }
        public string NomLieu { get; set; }
        public string AdresseLieu { get; set; }
        public int CPLieu { get; set; }
        public string VilleLieu { get; set; }
        public TypeLieu TypePlace { get; set; }
        public int CapaciteLieu { get; set; }
    }
}
