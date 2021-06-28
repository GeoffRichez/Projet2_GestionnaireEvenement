using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public enum RoleUtilisateur { Client, Mega, Presta }
    public class Utilisateur
    {

        public int Id { get; set; }

        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
        public string NomUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string FonctionUtilisateur { get; set; }

        [MaxLength(10)]
        [Display(Name = "Téléphone")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Le numéro de téléphone doit contenir 10 chiffres !")]
        public string TelephoneUtilisateur { get; set; }

        [Display(Name = "Rôle")]
        public RoleUtilisateur RoleUser { get; set; }

        [RegularExpression(@"^([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})", ErrorMessage = "Veuillez respecter le format d'une adresse email : xxxxxx@xxxxx.xx")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Veuillez renseigner une adresse email.")]
        [MaxLength(50)]
        public string Mail { get; set; }

    }
}




