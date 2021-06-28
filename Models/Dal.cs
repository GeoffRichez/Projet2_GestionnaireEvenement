using Geoffroy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;

        public Dal()
        {
            this._bddContext = new BddContext();
        }
        public void Dispose()
        {
            this._bddContext.Dispose();
        }

        public int CreerEvenement(Evenement evenement)
        {
            this._bddContext.Evenements.Add(evenement);
            this._bddContext.SaveChanges();
            return evenement.Id;
        }

        public int CreerEvenementEntreprise(Evenement evenement, Entreprise entreprise)
        {
            Evenement evenement1 = new Evenement { EntrepriseEvent = entreprise };
            this._bddContext.Evenements.Add(evenement);
            this._bddContext.SaveChanges();
            return evenement.Id;
        }

        public void CreerUtilisateur(string nom, string motdepasse, RoleUtilisateur role, string mail, int id = 0)
        {
            Utilisateur utilisateur = new Utilisateur { NomUtilisateur = nom, MotDePasse = motdepasse, RoleUser = role, Mail = mail };

            if(id != 0)
            {
                utilisateur.Id = id; 
            }

            this._bddContext.Utilisateurs.Add(utilisateur);
            this._bddContext.SaveChanges();
        }
        public void CreerEntreprise(Entreprise entreprise)
        {
            entreprise.UtilisateurEntreprise.MotDePasse = entreprise.UtilisateurEntreprise.PrenomUtilisateur.ToString();
            this._bddContext.Entreprises.Add(entreprise);
            this._bddContext.SaveChanges();
        }
        public int CreerDevis(Entreprise entreprise, Evenement evenement)
        {
            Devis devis = new Devis { EventDevis = evenement, EntrepriseDevis = entreprise, DateEmissionDevis = DateTime.Now, AvancementDevis = StatutDevis.Demande };
            this._bddContext.Deviss.Add(devis);
            this._bddContext.SaveChanges();
            return devis.Id;
        }

         public void CreerDevisPartie2(Entreprise entrepriseExistante, Evenement evenement, int id)
         {
            entrepriseExistante = this._bddContext.Entreprises.Find(id);
            Devis devis2 = new Devis { EntrepriseDevis = entrepriseExistante, EventDevis = evenement, Id = id };       
            this._bddContext.Deviss.Add(devis2);
            this._bddContext.SaveChanges();
         }

            public void UpdateUtilisateur(int id, string nomUtilisateur, string prenomUtilisateur,string fonction,string telephone, string mail)
        {
            Utilisateur utilisateurToUpdate = this._bddContext.Utilisateurs.Find(id);

            if(utilisateurToUpdate != null)
            {
                utilisateurToUpdate.NomUtilisateur = nomUtilisateur;
                utilisateurToUpdate.PrenomUtilisateur = prenomUtilisateur;
                utilisateurToUpdate.FonctionUtilisateur = fonction;
                utilisateurToUpdate.TelephoneUtilisateur = telephone;
                utilisateurToUpdate.Mail = mail;
                this._bddContext.SaveChanges();
            }
        }

        public void SupprimerUtilisateur(int id)
        {
            Utilisateur utilisateurToDelete = this._bddContext.Utilisateurs.Where(u => u.Id == id).FirstOrDefault();

            if(utilisateurToDelete != null)
            {
                this._bddContext.Utilisateurs.Remove(utilisateurToDelete);
                this._bddContext.SaveChanges();
            }

        }

        public List<Utilisateur> ObtientTousLesUtilisateurs()
        {
            List<Utilisateur> listeUtilisateur = this._bddContext.Utilisateurs.ToList();
            return listeUtilisateur;
        }

        public List<Entreprise> ObtientToutesLesEntreprises()
        {
            List<Entreprise> listeEntreprises = this._bddContext.Entreprises.Include(u=> u.UtilisateurEntreprise).Include(a=>a.Adresse).ToList();
            return listeEntreprises;
        }

        public void SupprimerEvenement(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvenement(int id, string nom)
        {
            throw new NotImplementedException();
        }        

        public Utilisateur ObtenirUtilisateur(int id)
        {
            return this._bddContext.Utilisateurs.FirstOrDefault(i => i.Id == id);
        }      
      
        public Utilisateur ObtenirUtilisateur(string idStr)
        {
            int id;
            if(int.TryParse(idStr, out id))
            {
                return this.ObtenirUtilisateur(id);
            }
            return null;
        }
        public Entreprise ObtenirEntreprise(int id)
        {
            return this._bddContext.Entreprises.FirstOrDefault(e => e.Id == id);            
        }

        public Evenement ObtenirEvenement(int id)
        {
            return this._bddContext.Evenements.Include(e=>e.LieuEvent).Include(e=>e.EntrepriseEvent).FirstOrDefault(ev => ev.Id == id);
        }     

        public void UpdateEntreprise(int id)
        {
            Utilisateur utilisateurToUpdate = this._bddContext.Utilisateurs.Find(id);
           

        }

        public List<Prestation> ObtientToutesLesPrestations()
        {
            return this._bddContext.Prestations.ToList();
        }

        public List<Devis> ObtientTousLesDevis()
        {
            return this._bddContext.Deviss.Include(d=>d.EventDevis).ThenInclude(d=>d.LieuEvent).Include(d=>d.EntrepriseDevis).ThenInclude(d=>d.UtilisateurEntreprise).ToList();
        }

        public List<Prestation> ObtientTousLesEventsPrestations(int idEvent)
        {
            List<PrestationEvent> prestations = _bddContext.PrestationEvents.Include(Pr => Pr.Prestation).Where(item => item.EvenementId == idEvent).ToList();
            
            return prestations.Select(prestations => prestations.Prestation).ToList();
        }





        private string EncodeMD5(string MotDePasse)
        {
            string motDePasseSel = "WebApplication1" + MotDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        public Utilisateur Authentifier(string mail, string motDePasse)
        {
            //string motpasse = EncodeMD5(MotDePasse);
            Utilisateur user = this._bddContext.Utilisateurs.FirstOrDefault(u => u.Mail == mail && u.MotDePasse == motDePasse);
            return user;
        }
        public void UpdateDevis(int id, StatutDevis statutDevis, float coutUnitaire)
        {
            Devis devisToUpdate = this._bddContext.Deviss.Find(id);
            if (devisToUpdate != null)
            {
                devisToUpdate.CoutEstime = devisToUpdate.EventDevis.ParticipantEvent * coutUnitaire;
                devisToUpdate.AvancementDevis = statutDevis;
                devisToUpdate.EventDevis.AvancementEvent = AvancementEvenement.AVenir;
                this._bddContext.SaveChanges();
            }
        }

        public int CreerDevisPartie22(Entreprise entrepriseExistante, Evenement evenement, int id)
        {
            entrepriseExistante = this._bddContext.Entreprises.Find(id);
            Devis devis2 = new Devis { EntrepriseDevis = entrepriseExistante, EventDevis = evenement };
            this._bddContext.Deviss.Add(devis2);
            this._bddContext.SaveChanges();
            return devis2.Id;
        }

        public Devis ObtenirDevis(int id)
        {
            return this._bddContext.Deviss.Include(d => d.EventDevis).ThenInclude(d=>d.LieuEvent).Include(d => d.EntrepriseDevis).ThenInclude(d => d.UtilisateurEntreprise).FirstOrDefault(ev => ev.Id == id);
        }
    }
}
