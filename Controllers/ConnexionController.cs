using System.Diagnostics;
using System.ComponentModel;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication1.Controllers
{
    public class ConnexionController : Controller
    {
        private IDal dal;

        public ConnexionController() : this(new Dal())
        {
        }

        private ConnexionController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        public ActionResult Index()
        {
            DevisViewModels viewModel = new DevisViewModels { Authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                viewModel.Utilisateur = dal.ObtenirUtilisateur(HttpContext.User.Identity.Name);
                return Redirect("/Connexion/Connecte");
            }
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(DevisViewModels viewModel, string returnUrl)
        {
            if (!string.IsNullOrEmpty(viewModel.Utilisateur.Mail)&& !string.IsNullOrEmpty(viewModel.Utilisateur.MotDePasse))
            {
                Utilisateur utilisateur = dal.Authentifier(viewModel.Utilisateur.Mail, viewModel.Utilisateur.MotDePasse);
                if (utilisateur != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, utilisateur.Id.ToString()),
                    };
                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                    HttpContext.SignInAsync(userPrincipal);

                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                        if (utilisateur.RoleUser == WebApplication1.Models.RoleUtilisateur.Mega)
                        {   
                            return Redirect("/Connexion/ConnecteMega");
                        } else
                     return Redirect("/Connexion/Connecte");            
                }
                ModelState.AddModelError("Utilisateur.Mail", "Nom d'utilisateur ou mot de passe incorrect(s)");
            }
            return View(viewModel);
        }

        public ActionResult FormulaireDevis2Connecte()
        {
           return Redirect("/Devis/FormulaireDevis2Connecte");

        }


        public ActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Connexion/Index");
        }

        public ActionResult Connecte()
        {
            string id = HttpContext.User.Identity.Name;
            ViewBag.id = id;
            int idConverted = Convert.ToInt32(id);
            List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
            DevisViewModels uvm = new DevisViewModels
            { 
                dvm = new DevisViewModels { 
                    MainDevis = listeDevis 
                } 
            };
            return View(uvm);
        }
        public ActionResult ConnecteMega()
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
                    } else
                    {
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

        public ActionResult Reglement()
        {
            return Redirect("/Informations/Index");
        }

        public ActionResult ModifierEntreprise(int id)
        {
            
            return Redirect("/Informations/ModifierEntreprise/"+id);
        }

        public ActionResult AfficheInterlocuteurs()
        {
            return View();
        }

        public ActionResult DemandeDevis()
        {
            string id = HttpContext.User.Identity.Name;
            ViewBag.id = id;
            int idConverted = Convert.ToInt32(id);
            using (IDal dal = new Dal())
            {
                List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
                List<Devis> listeDevisDemande = new List<Devis>();
                foreach (Devis d in listeDevis)
                {
                    if (d.AvancementDevis == WebApplication1.Models.StatutDevis.Demande)
                    {
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
        public ActionResult DevisEnCours()
        {
            string id = HttpContext.User.Identity.Name;
            ViewBag.id = id;
            int idConverted = Convert.ToInt32(id);
            using (IDal dal = new Dal())
            {
                List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
                List<Devis> listeDevisEnCours = new List<Devis>();
                foreach (Devis d in listeDevis)
                {
                    if (d.AvancementDevis == WebApplication1.Models.StatutDevis.EnCours)
                    {
                        listeDevisEnCours.Add(d);
                    }
                }
                UtilisateurViewModel uvm = new UtilisateurViewModel
                {
                    dvm = new DevisViewModels
                    {
                        MainDevis = listeDevisEnCours
                    }
                };
                return View(uvm);
            }
        }
        public ActionResult DevisValides()
        {
            using (IDal dal = new Dal())
            {
                string id = HttpContext.User.Identity.Name;
                ViewBag.id = id;
                int idConverted = Convert.ToInt32(id);
                List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
                List<Devis> listeDevisValide = new List<Devis>();
                foreach (Devis d in listeDevis)
                {
                    if (d.AvancementDevis == WebApplication1.Models.StatutDevis.Valide)
                    {
                        listeDevisValide.Add(d);
                    }
                }
                UtilisateurViewModel uvm = new UtilisateurViewModel
                {
                    dvm = new DevisViewModels
                    {
                        MainDevis = listeDevisValide
                    }
                };
                return View(uvm);
            }
        }

        public IActionResult ChangementDeStatut(int id)
        {
           
            using (IDal dal = new Dal())
            {
                Devis devis = dal.ObtientTousLesDevis().Where(dev => dev.Id == id).FirstOrDefault();
                dal.UpdateDevis(devis.Id, StatutDevis.EnCours, 85.05f);

                List<Devis> listeDevis = dal.ObtientTousLesDevis().ToList();
                List<Devis> listeDevisDemande = new List<Devis>();

                foreach (Devis d in listeDevis)
                {
                   
                    
                    if (d.AvancementDevis == StatutDevis.Demande)
                    {
                        
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
        public ActionResult EvenementAVenir()
        {
            string id = HttpContext.User.Identity.Name;
            ViewBag.id = id;
            int idConverted = Convert.ToInt32(id);
            List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
            UtilisateurViewModel uvm = new UtilisateurViewModel
            {
                dvm = new DevisViewModels
                {
                    MainDevis = listeDevis
                }
            };
            return View(uvm);
        }
        public ActionResult EvenementTermine()
        {
            string id = HttpContext.User.Identity.Name;
            ViewBag.id = id;
            int idConverted = Convert.ToInt32(id);
            List<Devis> listeDevis = dal.ObtientTousLesDevis().Where(d => d.EntrepriseDevis.UtilisateurEntreprise.Id == idConverted).ToList();
            UtilisateurViewModel uvm = new UtilisateurViewModel
            {
                dvm = new DevisViewModels
                {
                    MainDevis = listeDevis
                }
            };
            return View(uvm);
        }
    }
}
