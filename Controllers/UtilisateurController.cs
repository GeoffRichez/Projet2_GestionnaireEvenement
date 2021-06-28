using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class UtilisateurController : Controller
    {

        public readonly BddContext _context;

        public UtilisateurController()
        {
            _context = new BddContext();
        }

        // GET: Utilisateurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilisateurs.ToListAsync());
        }

        // GET: Utilisateurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var utilisateur = await _context.Utilisateurs
               .FirstOrDefaultAsync(m => m.Id == id);
            if (utilisateur == null)
            {
                return NotFound();
            }
            return View(utilisateur);
        }

        public IActionResult ModifierUtilisateur(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Utilisateur utilisateur = dal.ObtientTousLesUtilisateurs().Where(u => u.Id == id).FirstOrDefault();
                    if (utilisateur == null)
                    {
                        return View("Error");
                    }
                    DevisViewModels uvm = new DevisViewModels
                    {
                        Utilisateur = utilisateur,
                    };
                    return View(uvm);
                }
            }
            return View("Error");
        }


        [HttpPost]
        public IActionResult ModifierUtilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            using (IDal dal = new Dal())
            {
                dal.UpdateUtilisateur(utilisateur.Id, utilisateur.NomUtilisateur, utilisateur.PrenomUtilisateur,utilisateur.FonctionUtilisateur, utilisateur.TelephoneUtilisateur, utilisateur.Mail);
                return Redirect("/Home/Index");
            }
        }
    }
}
