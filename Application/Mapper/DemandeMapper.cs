using Application.Command.Demande;
using Application.Dtos;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    static class DemandeMapper
    {
        public static Core.Entity.Demande ToEntity(this AddDemandeCommand demande, Employe employe)
        {

            return new Core.Entity.Demande(demande.TypeDemande, employe, demande.DateDebut, demande.DateFin, demande.Commentaire, Core.Enum.StatutDemande.Initie);
        }

        public static DemandeDto ToDto(this Core.Entity.Demande demande)
        {
            DemandeDto UneDemande = new();
            UneDemande.Id = demande.Id;
            UneDemande.Employe = demande.Employe.ToDto();
            UneDemande.Statut = demande.Statut;
            UneDemande.DateDebut = demande.DateDebut;
            UneDemande.DateFin = demande.DateFin;
            UneDemande.TypeDemande = demande.TypeDemande;
            return UneDemande;

        }

    }
}
