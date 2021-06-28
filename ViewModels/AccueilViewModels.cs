using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class AccueilViewModels
    {
        public DateTime Date { get; set; }
        public List<Utilisateur> ListeUsers { get; set; }
        public List<Evenement> ListeEvents { get; set; }


    }
}
