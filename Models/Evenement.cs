using Geoffroy.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum TypeEvenement { Seminaire, TeamBuilding, FamilyDay, Congrès, LancementProduit, Colloque, JobDating, RoadShow }
    public enum FormatEvenement { Presentiel, Phygital, Digital}
    public enum AvancementEvenement { Initial, AVenir, EnCours, Passe, Cloture}
    public class Evenement
    {
        public int Id { get; set; }
        public TypeEvenement TypeEvent { get; set; }
        public string ThemeEvent { get; set; }
        public FormatEvenement FormatEvent { get; set; }
        public Lieu LieuEvent { get; set; }
        public DateTime DateEvent { get; set; }
        public float DureeEvent { get; set; }
        public int ParticipantEvent { get; set; }
        public List<Prestation> ListePrestation { get; set; }
        //public List<string> PrestationSouhaitee { get; set; }
        //[NotMapped]
        //public List<SelectListItem> PrestationPossible { get; set; }
        public string Description { get; set; }
        public AvancementEvenement AvancementEvent { get; set; }
        public Entreprise EntrepriseEvent { get; set; }


        //public Evenement()
        //{
        //    PrestationSouhaitee = new List<string>();
        //    PrestationPossible = new List<SelectListItem>();
        //}

    }


}
