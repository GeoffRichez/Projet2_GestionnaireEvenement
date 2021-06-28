using Geoffroy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication1.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Lieu> Lieux { get; set; }
        public DbSet<Presta> Prestataires { get; set; }
        public DbSet<Mega> MegaBoss { get; set; }
        public DbSet<Devis> Deviss { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<PrestationEvent> PrestationEvents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=;database=megabase");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            Utilisateur Mega = new Utilisateur
            {
                NomUtilisateur = "",
                PrenomUtilisateur = "",
                RoleUser = RoleUtilisateur.Mega,
                MotDePasse = "admin",
                Mail = "mega@gmail.com"
            };
            Lieu Ribaudiere = new Lieu
            {
                NomLieu = "Clos de la Ribaudière",
                AdresseLieu = "47 rue de l'Eglise",
                CPLieu = 86770,
                VilleLieu = "Vouneuil",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 470
            };
            Lieu PalaisCongres = new Lieu
            {
                NomLieu = "Palais des congrès",
                AdresseLieu = "Porte Maillot",
                CPLieu = 75017,
                VilleLieu = "Paris",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 2500
            };
            Lieu OperaGarnier = new Lieu
            {
                NomLieu = "Opéra Garnier",
                AdresseLieu = "2 place de l'Opéra",
                CPLieu = 75008,
                VilleLieu = "Paris",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 350
            };
            Lieu CircuitMans = new Lieu
            {
                NomLieu = "Circuit du Mans",
                AdresseLieu = "2 avenue Leclerc",
                CPLieu = 72000,
                VilleLieu = "Le Mans",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 750
            };
            Lieu VillaModigliani = new Lieu
            {
                NomLieu = "Villa Modigliani",
                AdresseLieu = "39 rue de la Butte",
                CPLieu = 75018,
                VilleLieu = "Paris",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 45
            };
            Lieu Sofitel = new Lieu
            {
                NomLieu = "Sofitel Marseille",
                AdresseLieu = "2 avenue Saint Jean",
                CPLieu = 13001,
                VilleLieu = "Marseille",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 310
            };
            Lieu ChateauMirambeau = new Lieu
            {
                NomLieu = "Chateau Mirambeau",
                AdresseLieu = "23 rue Duchatel",
                CPLieu = 17150,
                VilleLieu = "Mirambeau",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 120
            };
            Lieu Cherqui = new Lieu
            {
                NomLieu = "Fondation Vasarely",
                AdresseLieu = "78 boulevard Dubreuil",
                CPLieu = 13710,
                VilleLieu = "Aix-en-Provence",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 460
            };
            Lieu Bourget = new Lieu
            {
                NomLieu = "Salon du Bourget",
                AdresseLieu = "Zone de l'aéroport",
                CPLieu = 93013,
                VilleLieu = "Le Bourget",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 3700
            };
            Lieu ForetArts = new Lieu
            {
                NomLieu = "La forêt des arts",
                AdresseLieu = "3 rue du Chateau",
                CPLieu = 37360,
                VilleLieu = "Saint Antoine",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 75
            };
            Utilisateur Patrick = new Utilisateur
            {
                NomUtilisateur = "Rakoto",
                PrenomUtilisateur = "Patrick",
                FonctionUtilisateur = "Directeur",
                TelephoneUtilisateur = "076879874",
                RoleUser = RoleUtilisateur.Client,
                MotDePasse = "patrick",
                Mail = "patrick@gmail.com",
            };
            Prestation PrestationLocation = new Prestation
            {
                Id = 1,
                NomPrestation = "Lieu",
                Description = "Avez-vous besoin de louer un lieu pour accueillir votre événement ?"
            };
            Prestation PrestationTraiteur = new Prestation
            {
                Id = 2,
                NomPrestation = "Traiteur",
                Description = "Prestation de restauration "
            };
            Prestation PrestationPhotographe = new Prestation
            {
                Id = 3,
                NomPrestation = "Photographe",
                Description = "Présence d'un ou plusieurs photographes"
            };
            Prestation PrestationSpeaker = new Prestation
            {
                Id = 4,
                NomPrestation = "Animateur de conférence",
                Description = "Présence d'un intervenant et/ou d'un animateur"
            };
            Prestation PrestationAudiovisuel = new Prestation
            {
                Id = 5,
                NomPrestation = "Audiovisuel",
                Description = "Enregistrement et retransmission de l'événement"
            };
            Prestation PrestationMateriel = new Prestation
            {
                Id = 6,
                NomPrestation = "Matériel",
                Description = "Location de table, chaises, service de table..."
            };
            Prestation PrestationRealite = new Prestation
            {
                Id = 7,
                NomPrestation = "Réalité virtuelle",
                Description = "Expérience façon Second Life"
            };
            Evenement Seminaire = new Evenement
            {
                ThemeEvent = "Faune et flore en forêt amazonienne",
                TypeEvent = TypeEvenement.Seminaire,
                FormatEvent = FormatEvenement.Phygital,
                LieuEvent = Ribaudiere,
                DateEvent = new DateTime(2021, 07, 07),
                DureeEvent = 3,
                ParticipantEvent = 450,
                Description = "Nous souhaitons organiser un séminaire en lien avec le CNED qui fournira les intervenants",
                AvancementEvent = AvancementEvenement.AVenir
            };
            Evenement SoireeLancement = new Evenement
            {
                ThemeEvent = "Solutions PME",
                TypeEvent = TypeEvenement.LancementProduit,
                FormatEvent = FormatEvenement.Presentiel,
                LieuEvent = OperaGarnier,
                DateEvent = new DateTime(2021, 09, 07),
                DureeEvent = 1,
                ParticipantEvent = 97,
                Description = "Cette soirée de lancement de notre nouvelle gamme de produits PME est organisée pour nos principaux prescripteurs",
                AvancementEvent = AvancementEvenement.AVenir
            };
            Lieu Autre = new Lieu
            {
                NomLieu = "Autre",
                AdresseLieu = "Non applicable",
                CPLieu = 00001,
                VilleLieu = "Non applicable",
                TypePlace = TypeLieu.Lieu_Prestataire,
                CapaciteLieu = 9999
            };
            Entreprise Veolia = new Entreprise
            {
                NomEntreprise = "Veolia",
                Siret = 4984487255681,
                Adresse = new Lieu
                {
                    NomLieu = "Veolia Rueil",
                    AdresseLieu = "14 avenue du Général de Gaulle",
                    CPLieu = 73210,
                    VilleLieu = "Rueil-Malmaison",
                    TypePlace = TypeLieu.Lieu_Entreprise
                },
                UtilisateurEntreprise = new Utilisateur
                {
                    NomUtilisateur = "Courteille",
                    PrenomUtilisateur = "Pierre",
                    FonctionUtilisateur = "Responsable RH",
                    TelephoneUtilisateur = "0768987412",
                    RoleUser = RoleUtilisateur.Client,
                    MotDePasse = "pierre",
                    Mail = "pierre@gmail.com",
                }
            };
            Entreprise DayByDay = new Entreprise
            {
                NomEntreprise = "Day by Day",
                Siret = 4094568745568,
                Adresse = new Lieu
                {
                    NomLieu = "Day by Day IDF",
                    AdresseLieu = "42 rue de Charenton",
                    CPLieu = 75012,
                    VilleLieu = "Paris",
                    TypePlace = TypeLieu.Lieu_Entreprise
                },
                UtilisateurEntreprise = new Utilisateur
                {
                    NomUtilisateur = "Jour",
                    PrenomUtilisateur = "Caroline",
                    FonctionUtilisateur = "Responsable de centre",
                    TelephoneUtilisateur = "0787087412",
                    RoleUser = RoleUtilisateur.Client,
                    MotDePasse = "caroline",
                    Mail = "caroline@gmail.com",
                }
            };
            Entreprise HMNF = new Entreprise
            {
                NomEntreprise = "HMN Financial",
                Siret = 7834665465400,
                Adresse = new Lieu
                {
                    NomLieu = "HMNF Worldwide",
                    AdresseLieu = "42 avenue des Champs-Elysées",
                    CPLieu = 75008,
                    VilleLieu = "Paris",
                    TypePlace = TypeLieu.Lieu_Entreprise
                },
                UtilisateurEntreprise = new Utilisateur
                {
                    NomUtilisateur = "Simoni",
                    PrenomUtilisateur = "Louis",
                    FonctionUtilisateur = "Directeur marketing",
                    TelephoneUtilisateur = "0603897430",
                    RoleUser = RoleUtilisateur.Client,
                    MotDePasse = "louis",
                    Mail = "louis@gmail.com",
                }
            };
            Entreprise Aromes = new Entreprise
            {
                NomEntreprise = "Arômes Traiteur",
                Siret = 8749556735214,
                Adresse = new Lieu
                {
                    NomLieu = "Arômes Traiteur",
                    AdresseLieu = "75 Rue des Rosiers",
                    CPLieu = 78000,
                    VilleLieu = "Versailles",
                    TypePlace = TypeLieu.Lieu_Prestataire
                },
                UtilisateurEntreprise = new Utilisateur
                {
                    NomUtilisateur = "Gobain",
                    PrenomUtilisateur = "Alix",
                    FonctionUtilisateur = "Directrice",
                    TelephoneUtilisateur = "0648798513",
                    RoleUser = RoleUtilisateur.Presta,
                    MotDePasse = "alix",
                    Mail = "alix@gmail.com",
                }
            };
            Evenement OnTheRoad = new Evenement
            {
                ThemeEvent = "Volex",
                TypeEvent = TypeEvenement.RoadShow,
                FormatEvent = FormatEvenement.Phygital,
                LieuEvent = Autre,
                DateEvent = new DateTime(2021, 06, 01),
                DureeEvent = 21,
                ParticipantEvent = 15,
                Description = "Tournée des principaux magasins en région Rhône-Alpes",
                EntrepriseEvent = Veolia,
                AvancementEvent = AvancementEvenement.AVenir
            };
            Evenement FeteEte = new Evenement
            {
                ThemeEvent = "Célébration de l'été",
                TypeEvent = TypeEvenement.TeamBuilding,
                FormatEvent = FormatEvenement.Digital,
                LieuEvent = Autre,
                DateEvent = new DateTime(2021, 06, 21),
                DureeEvent = 1,
                ParticipantEvent = 163,
                Description = "Nous voulons rassembler nos équipes pour fêtes les beaux jours, même si seulement virtuellement",
                EntrepriseEvent = Veolia,
                AvancementEvent = AvancementEvenement.AVenir
            };
            Evenement FinanceVerte = new Evenement
            {
                ThemeEvent = "Financement et écologie",
                TypeEvent = TypeEvenement.Congrès,
                FormatEvent = FormatEvenement.Phygital,
                LieuEvent = ForetArts,
                DateEvent = new DateTime(2021, 11, 21),
                DureeEvent = 2,
                ParticipantEvent = 250,
                EntrepriseEvent = Veolia,
                Description = "Organisation de débats et tables rondes sur le financement d'actions vertes et les bénéfices attendus",
            };
            Evenement FamilyDay = new Evenement
            {
                ThemeEvent = "Naturalia en famille",
                TypeEvent = TypeEvenement.FamilyDay,
                FormatEvent = FormatEvenement.Presentiel,
                DateEvent = new DateTime(2021, 06, 15),
                DureeEvent = 2,
                ParticipantEvent = 150,
                LieuEvent = ChateauMirambeau,
                Description = "Conjoints et enfants sont conviés pour venir découvrir l'univers de travail de Naturalia au quotidien",
                EntrepriseEvent = new Entreprise
                {
                    NomEntreprise = "Naturalia",
                    Siret = 30247464800664,
                    Adresse = new Lieu
                    {
                        NomLieu = "Naturalia Sebastopol",
                        AdresseLieu = "94 avenue du Parc",
                        CPLieu = 92040,
                        VilleLieu = "Blois",
                        TypePlace = TypeLieu.Lieu_Entreprise
                    },
                    UtilisateurEntreprise = Patrick
                },
                AvancementEvent = AvancementEvenement.AVenir
            };
            
            Devis devis01 = new Devis
            {
                Id = 1,
                EventDevis = Seminaire,
                EntrepriseDevis = Veolia,
                DateEmissionDevis = new DateTime(2021, 05, 26),
                AvancementDevis = StatutDevis.Demande
            };
            Devis devis02 = new Devis
            {
                Id = 2,
                EventDevis = FinanceVerte,
                EntrepriseDevis = HMNF,
                DateEmissionDevis = new DateTime(2021, 05, 27),
                AvancementDevis = StatutDevis.Demande
            };
            Devis devis03 = new Devis
            {
                Id = 3,
                EventDevis = FeteEte,
                EntrepriseDevis = Veolia,
                DateEmissionDevis = new DateTime(2021, 05, 09),
                AvancementDevis = StatutDevis.EnCours
            };
            Devis devis04 = new Devis
            {
                Id = 4,
                EventDevis = OnTheRoad,
                EntrepriseDevis = Veolia,
                DateEmissionDevis = new DateTime(2019, 05, 24),
                AvancementDevis = StatutDevis.Demande
            };
            Devis devis05 = new Devis
            {
                Id = 5,
                EventDevis = SoireeLancement,
                EntrepriseDevis = Veolia,
                DateEmissionDevis = new DateTime(2021, 02, 06),
                AvancementDevis = StatutDevis.Valide
            };
            Devis devis06 = new Devis
            {
                Id = 6,
                EventDevis = FamilyDay,
                EntrepriseDevis = Veolia,
                DateEmissionDevis = new DateTime(2019, 06, 06),
                AvancementDevis = StatutDevis.EnCours
            };
            this.Prestations.AddRange(
                PrestationLocation, PrestationTraiteur, PrestationPhotographe, PrestationSpeaker, PrestationAudiovisuel, PrestationMateriel, PrestationRealite
                );
            this.Evenements.AddRange(
                Seminaire, FamilyDay, FinanceVerte, FeteEte, OnTheRoad, SoireeLancement
            );
            this.Entreprises.AddRange(
                Veolia, Aromes, HMNF, DayByDay
            );
            this.Lieux.AddRange(
             OperaGarnier, Ribaudiere, ForetArts, VillaModigliani, Bourget, Cherqui, Sofitel, PalaisCongres, CircuitMans, ChateauMirambeau
          );
            this.Deviss.AddRange(
               devis01, devis02, devis03, devis04, devis05, devis06
               );
            this.Utilisateurs.Add(Mega);
            this.PrestationEvents.AddRange(
                new PrestationEvent
                {
                    Id = 1,
                    EvenementId = 1,
                    PrestationId = 1,
                },
                new PrestationEvent
                {
                    Id = 2,
                    EvenementId = 1,
                    PrestationId = 2,
                },
                new PrestationEvent
                {
                    Id = 3,
                    EvenementId = 2,
                    PrestationId = 3,
                },
                new PrestationEvent
                {
                    Id = 4,
                    EvenementId = 2,
                    PrestationId = 5,
                }
                );
            this.SaveChanges();
        }
    }
}


