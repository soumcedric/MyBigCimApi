using Application.Command.EmployeFonction;
using Application.Dtos;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    static class EmployeFonctionMapper
    {
        public static EmployeFonction ToRequest(Employe employe, Fonction fonction, Service service)
        {
            EmployeFonction employeFonction = new();
            employeFonction.Fonction = fonction;
            employeFonction.Employe = employe;
            employeFonction.Service = service;

            return employeFonction;
        }

        public static EmployeFonctionDto ToDto(this EmployeFonction value)
        {
            return new EmployeFonctionDto
            {
                Matricule = value.Employe.Matricule,
                Nom = value.Employe.Nom,
                Prenom = value.Employe.Prenom,
                Fonction = value.Fonction.Libelle,
                Service = value.Service.Libelle,
                Telephone = value.Employe.Telephone
            };
        }
    }
}
