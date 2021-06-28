using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Entreprise
    {
        public int Id { get; set; }
        public string NomEntreprise { get; set; }
        public long Siret { get; set; }
        public virtual Lieu Adresse { get; set; }
        public virtual Utilisateur UtilisateurEntreprise { get; set; }

    }
}
