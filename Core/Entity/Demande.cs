using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Demande:EntityBase
    {
        public StatutDemande Statut { get; private set; }
        public TypeDemande TypeDemande { get; private set; }
        public Employe Employe { get; private set; }
        public DateOnly DateDebut { get; private set; }
        public DateOnly DateFin { get; private set; }
        public string Commentaire { get; private set; }


        public Demande()
        {
            
        }

        public Demande( TypeDemande typeDemande, Employe employe,
                        DateOnly dateDebut, DateOnly dateFin, string commentaire, StatutDemande statut)
        {
            
            Statut = StatutDemande.Initie;
            TypeDemande = typeDemande;
            Employe = employe;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Commentaire = commentaire;
            Statut = statut;
        }
    }
}
