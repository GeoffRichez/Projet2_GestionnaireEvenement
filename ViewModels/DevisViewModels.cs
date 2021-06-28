using Geoffroy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class DevisViewModels
    {
        public Evenement MainEvenement { get; set; }
        public Entreprise MainEntreprise { get; set; }
        public Utilisateur MainUtilisateur { get; set; }
        public List<Prestation> MainPrestation { get; set; }
        public List<Devis> MainDevis { get; set; }

        public Utilisateur Utilisateur { get; set; }
        public bool Authentifie { get; set; }
        public DevisViewModels dvm { get; set; }
    }
    public class DevisViewModel
    {
        public int DevisId { get; set; }
    }
}
