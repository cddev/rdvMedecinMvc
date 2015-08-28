using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    public class RdvMedecinContext : DbContext
    {
        // les entités
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Creneau> Creneaux { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Rv> Rvs { get; set; }

        // constructeur
        public RdvMedecinContext()
          : base("RdvMedecinEntities")
        {
            //Initializer à utiliser pour filtrer les crénaux disponibles à partir de requête Linq
            //ou Expression Lambda
            //Database.SetInitializer<RdvMedecinContext>(new RdvMedecinInitializer());

            //Initialiser à utiliser pour filtrer les crénaux disponibles à partir 
            //d'une procédure stockée
            Database.SetInitializer<RdvMedecinContext>(new RdvMedecinInitializerSansDropDb());
        }
    }
    // initialisation de la base
    public class RdvMedecinInitializer : DropCreateDatabaseAlways<RdvMedecinContext>
    {
        protected override void Seed(RdvMedecinContext context)
        {
            base.Seed(context);
            // on initialise la base
            // les clients
            Patient[] patients ={
        new Patient{ Titre = "Mr", Nom = "Martin", Prenom = "Jules" },
        new Patient { Titre = "Mme", Nom = "German", Prenom = "Christine" },
        new Patient { Titre = "Mr", Nom = "Jacquard", Prenom = "Jules" },
        new Patient { Titre = "Melle", Nom = "Bistrou", Prenom = "Brigitte" }
     };
            context.Patients.AddRange(patients.ToList<Patient>());

            //foreach (Patient patient in patients)
            //{
            //    context.Patients.Add(patient);
            //}
            
            // les médecins
            Medecin[] medecins ={
        new Medecin { Titre = "Mme", Nom = "Pelissier", Prenom = "Marie" },
        new Medecin { Titre = "Mr", Nom = "Bromard", Prenom = "Jacques" },
        new Medecin { Titre = "Mr", Nom = "Jandot", Prenom = "Philippe" },
        new Medecin { Titre = "Melle", Nom = "Jacquemot", Prenom = "Justine" }
     };
            foreach (Medecin medecin in medecins)
            {
                context.Medecins.Add(medecin);
            }
            // les créneaux horaires
            Creneau[] creneaux ={
        new Creneau{ Hdebut=8,Mdebut=0,Hfin=8,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=20,Hfin=8,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=40,Hfin=9,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=0,Hfin=9,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=20,Hfin=9,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=40,Hfin=10,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=0,Hfin=10,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=20,Hfin=10,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=40,Hfin=11,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=0,Hfin=11,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=20,Hfin=11,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=40,Hfin=12,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=0,Hfin=14,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=20,Hfin=14,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=40,Hfin=15,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=0,Hfin=15,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=20,Hfin=15,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=40,Hfin=16,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=0,Hfin=16,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=20,Hfin=16,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=40,Hfin=17,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=0,Hfin=17,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=20,Hfin=17,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=40,Hfin=18,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=0,Hfin=8,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=8,Mdebut=20,Hfin=8,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=8,Mdebut=40,Hfin=9,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=0,Hfin=9,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=20,Hfin=9,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=40,Hfin=10,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=0,Hfin=10,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=20,Hfin=10,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=40,Hfin=11,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=0,Hfin=11,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=20,Hfin=11,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=40,Hfin=12,Mfin=0,Medecin=medecins[1]},
      };
            foreach (Creneau creneau in creneaux)
            {
                context.Creneaux.Add(creneau);
            }
            // les Rdv
            context.Rvs.Add(new Rv { Jour = new System.DateTime(2012, 07, 22), Patient = patients[0], Creneau = creneaux[0] });
        }
    }

    public class RdvMedecinInitializerSansDropDb : DropCreateDatabaseIfModelChanges<RdvMedecinContext>
    {
       protected override void Seed(RdvMedecinContext context)
        {
            base.Seed(context);
            // on initialise la base
            // les clients
            Patient[] patients ={
        new Patient{ Titre = "Mr", Nom = "Martin", Prenom = "Jules" },
        new Patient { Titre = "Mme", Nom = "German", Prenom = "Christine" },
        new Patient { Titre = "Mr", Nom = "Jacquard", Prenom = "Jules" },
        new Patient { Titre = "Melle", Nom = "Bistrou", Prenom = "Brigitte" }
                                };
            context.Patients.AddRange(patients.ToList<Patient>());

            //foreach (Patient patient in patients)
            //{
            //    context.Patients.Add(patient);
            //}

            // les médecins
            Medecin[] medecins ={
        new Medecin { Titre = "Mme", Nom = "Pelissier", Prenom = "Marie" },
        new Medecin { Titre = "Mr", Nom = "Bromard", Prenom = "Jacques" },
        new Medecin { Titre = "Mr", Nom = "Jandot", Prenom = "Philippe" },
        new Medecin { Titre = "Melle", Nom = "Jacquemot", Prenom = "Justine" }
                                };
            foreach (Medecin medecin in medecins)
            {
                context.Medecins.Add(medecin);
            }
            // les créneaux horaires
            Creneau[] creneaux ={
        new Creneau{ Hdebut=8,Mdebut=0,Hfin=8,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=20,Hfin=8,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=40,Hfin=9,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=0,Hfin=9,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=20,Hfin=9,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=9,Mdebut=40,Hfin=10,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=0,Hfin=10,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=20,Hfin=10,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=10,Mdebut=40,Hfin=11,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=0,Hfin=11,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=20,Hfin=11,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=11,Mdebut=40,Hfin=12,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=0,Hfin=14,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=20,Hfin=14,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=14,Mdebut=40,Hfin=15,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=0,Hfin=15,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=20,Hfin=15,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=15,Mdebut=40,Hfin=16,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=0,Hfin=16,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=20,Hfin=16,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=16,Mdebut=40,Hfin=17,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=0,Hfin=17,Mfin=20,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=20,Hfin=17,Mfin=40,Medecin=medecins[0]},
        new Creneau{ Hdebut=17,Mdebut=40,Hfin=18,Mfin=0,Medecin=medecins[0]},
        new Creneau{ Hdebut=8,Mdebut=0,Hfin=8,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=8,Mdebut=20,Hfin=8,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=8,Mdebut=40,Hfin=9,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=0,Hfin=9,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=20,Hfin=9,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=9,Mdebut=40,Hfin=10,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=0,Hfin=10,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=20,Hfin=10,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=10,Mdebut=40,Hfin=11,Mfin=0,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=0,Hfin=11,Mfin=20,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=20,Hfin=11,Mfin=40,Medecin=medecins[1]},
        new Creneau{ Hdebut=11,Mdebut=40,Hfin=12,Mfin=0,Medecin=medecins[1]},
                         };
            foreach (Creneau creneau in creneaux)
            {
                context.Creneaux.Add(creneau);
            }
            // les Rdv
            context.Rvs.Add(new Rv { Jour = new System.DateTime(2012, 07, 22), Patient = patients[0], Creneau = creneaux[0] });
        } 
    }
}


