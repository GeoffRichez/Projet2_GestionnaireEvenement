using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class InformationsController : Controller
    {
        public readonly BddContext _context;

        public InformationsController()
        {
            _context = new BddContext();
        }
        // GET: Entreprise
        public IActionResult ModifierEntreprise(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Entreprise entreprise = dal.ObtientToutesLesEntreprises().Where(ent => ent.UtilisateurEntreprise.Id == id).FirstOrDefault();
                    if (entreprise == null)
                    {
                        return View("Error");
                    }
                    return View(entreprise);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult ModifierEntreprise(Entreprise entreprise)
        {
            using (IDal dal = new Dal())
            {
                dal.UpdateUtilisateur(entreprise.UtilisateurEntreprise.Id, entreprise.UtilisateurEntreprise.NomUtilisateur, entreprise.UtilisateurEntreprise.PrenomUtilisateur, entreprise.UtilisateurEntreprise.FonctionUtilisateur, entreprise.UtilisateurEntreprise.TelephoneUtilisateur, entreprise.UtilisateurEntreprise.Mail);

                return View(entreprise);
            }
        }

        public IActionResult InfoSociete()
        {
            return View();
        }

        public IActionResult Index()
        {
            using (IDal dal = new Dal())
            {
                List<Devis> listeDevis = dal.ObtientTousLesDevis();
                List<Devis> listeDevisDemande = new List<Devis>();
                foreach (Devis d in listeDevis)
                {
                    if (d.AvancementDevis == WebApplication1.Models.StatutDevis.Demande)
                    {
                        dal.UpdateDevis(d.Id, StatutDevis.Demande, 85.05f);
                        listeDevisDemande.Add(d);
                    }
                }
                UtilisateurViewModel uvm = new UtilisateurViewModel
                {
                    dvm = new DevisViewModels
                    {
                        MainDevis = listeDevisDemande
                    }
                };


                return View(uvm);
            }
        }
    }
}
