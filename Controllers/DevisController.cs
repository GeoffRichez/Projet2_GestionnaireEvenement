using Geoffroy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class DevisController : Controller
    {
        public IActionResult FormulaireDevis1(DevisViewModels uvm)
        {            
            return View();
        }
      
        public IActionResult FormulaireDevis2(DevisViewModels uvm)
        {
            Dal dal = new Dal();
            uvm.MainPrestation = dal.ObtientToutesLesPrestations();
            return View(uvm);
        }

        [HttpPost]
        public IActionResult FormulaireDevis2(List<string> PrestaType, DevisViewModels uvm, string submit)
        {
            if(submit == "suivant")
            { 
                Dal dal = new Dal();
                dal.CreerEntreprise(uvm.MainEntreprise);
                int idEvent = dal.CreerEvenement(uvm.MainEvenement);
                List<Prestation> listePresta = dal.ObtientToutesLesPrestations();
                foreach(string presta in PrestaType)
                {
                    int prestaId = listePresta.Where(p => p.NomPrestation == presta).FirstOrDefault().Id;
                    BddContext bddContext = new BddContext();
                    bddContext.PrestationEvents.Add(new PrestationEvent { PrestationId = prestaId, EvenementId = idEvent});
                    bddContext.SaveChanges();
                }
                int idDevis = dal.CreerDevis(uvm.MainEntreprise, uvm.MainEvenement);
                return RedirectToAction("FormulaireDevis3", new DevisViewModel { DevisId = idDevis });
                //var prestation = string.Join(",", uvm.MainEvenement.PrestationSouhaitee);
            }
            //uvm.MainEvenement.PrestationPossible = (List<SelectListItem>)ObtenirPrestation();
            if(submit == "precedent")
            {
                return View("FormulaireDevis1", uvm);
            }
            return View();
        }

        public IActionResult FormulaireDevis2Connecte(DevisViewModels uvm)
        {                 
            Dal dal = new Dal();        
            uvm.MainPrestation = dal.ObtientToutesLesPrestations();
            return View(uvm);
        }

        [HttpPost]
        public IActionResult FormulaireDevis2Connecte(List<string> PrestaType, DevisViewModels uvm, string submit, int id)
        {
            if (submit == "suivant")
            {
                Dal dal = new Dal();
                uvm.MainEntreprise = dal.ObtientToutesLesEntreprises().Where(ent => ent.UtilisateurEntreprise.Id == id).FirstOrDefault();

                int idEvent = dal.CreerEvenementEntreprise(uvm.MainEvenement, uvm.MainEntreprise);

                List<Prestation> listePresta = dal.ObtientToutesLesPrestations();

                foreach (string presta in PrestaType)
                {
                    int prestaId = listePresta.Where(p => p.NomPrestation == presta).FirstOrDefault().Id;
                    BddContext bddContext = new BddContext();
                    bddContext.PrestationEvents.Add(new PrestationEvent { PrestationId = prestaId, EvenementId = idEvent });
                    bddContext.SaveChanges();
                }
                int idDevis = dal.CreerDevisPartie22(uvm.MainEntreprise, uvm.MainEvenement, uvm.MainEntreprise.Id);

                return RedirectToAction("FormulaireDevis3", new DevisViewModel { DevisId= idDevis});              
            }          
            return View();
        }


        public IActionResult FormulaireDevis3(DevisViewModel id)
        {
            return View(id);
        }



        private List<SelectListItem> ObtenirPrestation()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="Lieu", Value="Lieu"},
                new SelectListItem{ Text="Traiteur", Value="Traiteur"},
                new SelectListItem{ Text="Photographe", Value="Photographe"},
                new SelectListItem{ Text="Speaker", Value="Speaker"},
                new SelectListItem{ Text="Audiovisuel", Value="Audiovisuel"},
                new SelectListItem{ Text="Location de matériel", Value="LocationMateriel"},
                new SelectListItem{ Text="Réalité virtuelle", Value="VR" }
            };
        }

        public IActionResult RecapitulatifDevis(int id)
        {
            Dal dal = new Dal();
            var devis = dal.ObtenirDevis(id);
            RecapDevisViewModel rdvm = new RecapDevisViewModel();
            rdvm.DateEvent = devis.EventDevis.DateEvent;
            rdvm.PrenomUtilisateur = devis.EntrepriseDevis.UtilisateurEntreprise.PrenomUtilisateur;
            rdvm.DescriptionEvent = devis.EventDevis.Description;
            rdvm.DevisId = devis.EventDevis.Id;
            rdvm.FormatEvent = devis.EventDevis.FormatEvent.ToString();
            rdvm.NomEntreprise = devis.EntrepriseDevis.NomEntreprise;
            rdvm.NomUtilisateur = devis.EntrepriseDevis.UtilisateurEntreprise.NomUtilisateur;
            rdvm.ThemeEvent = devis.EventDevis.ThemeEvent;
            rdvm.TypeEvent = devis.EventDevis.TypeEvent.ToString();
            return View(rdvm);
        }

        public IActionResult RecapitulatifEvent(int id)
        {
            Dal dal = new Dal();
            var evenement = dal.ObtenirEvenement(id);
            RecapDevisViewModel rdvm = new RecapDevisViewModel();
            rdvm.Entreprise = evenement.EntrepriseEvent;
            rdvm.DateEvent = evenement.DateEvent;
            rdvm.DescriptionEvent = evenement.Description;
            rdvm.DevisId = evenement.Id;
            rdvm.FormatEvent = evenement.FormatEvent.ToString();
            rdvm.ThemeEvent = evenement.ThemeEvent;
            rdvm.TypeEvent = evenement.TypeEvent.ToString();
            rdvm.lieux = evenement.LieuEvent;
            rdvm.NombreParticipant = evenement.ParticipantEvent;
            return View(rdvm);
        }
    }
}
