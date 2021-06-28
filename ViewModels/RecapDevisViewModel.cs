using System;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RecapDevisViewModel
    {
        public string NomUtilisateur { get; set; }
        public string NomEntreprise { get; set; }
        public int DevisId { get; set; }
        public DateTime DateEvent { get; set; }
        public string FormatEvent { get; set; }
        public string TypeEvent { get; set; }
        public string DescriptionEvent { get; set; }
        public string ThemeEvent { get; set; }
        public Lieu lieux { get; set; }  
        public Entreprise Entreprise { get; set; }
        public int NombreParticipant { get; set; }
        public string PrenomUtilisateur { get; set; }
    }
}