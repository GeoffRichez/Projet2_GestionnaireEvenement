using Geoffroy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IDal : IDisposable
    {
              
        void CreerUtilisateur(string nom, string motdepasse, RoleUtilisateur role, string mail, int id = 0);
        void UpdateUtilisateur(int id, string nomUtilisateur,string prenomUtilisateur,string fonction, string telephone,string mail);
        void SupprimerUtilisateur(int id);
        int CreerEvenement(Evenement evenement);
        int CreerEvenementEntreprise(Evenement evenement, Entreprise entreprise);
        void CreerEntreprise(Entreprise entreprise);
        int CreerDevis(Entreprise entreprise, Evenement evenement);
        void CreerDevisPartie2(Entreprise entreprise, Evenement evenement, int id);
        int CreerDevisPartie22(Entreprise entreprise, Evenement evenement, int id);

        void UpdateEvenement(int id, string nom);
        void SupprimerEvenement(int id);
        void UpdateDevis(int id, StatutDevis statutDevis, float coutUnitaire);

        List<Prestation> ObtientToutesLesPrestations();
        List<Prestation> ObtientTousLesEventsPrestations(int idEvent);
        List<Utilisateur> ObtientTousLesUtilisateurs();
        List<Entreprise> ObtientToutesLesEntreprises();
        List<Devis> ObtientTousLesDevis();
        Devis ObtenirDevis(int id);
        Utilisateur Authentifier(string NomUtilisateur, string MotDePasse);
        Utilisateur ObtenirUtilisateur(int id);
        Utilisateur ObtenirUtilisateur(string idStr);
        Entreprise ObtenirEntreprise(int id);
        Evenement ObtenirEvenement(int id);
        void UpdateEntreprise(int id);
    }
}
