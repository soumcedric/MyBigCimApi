using Application.Command.Employe;
using Application.Dtos;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    static class EmployeMapper
    {
        public static Employe ToRequest(this AddEmployeCommand value)
        {
            return new Employe(value.Matricule, value.Nom, value.Prenom, value.Email, value.TelephoneProfessionnel, value.TelephonePersonnel);
        }

        public static EmployeDto ToDto(this Employe value)
        {
            return new EmployeDto
            {
                Id = value.Id,
                Email = value.Email,
                Matricule = value.Matricule,
                Nom = value.Nom,
                Prenom = value.Prenom,
                Telephone = value.Telephone,
                TelephoneProfessionnel = value.TelephoneProfessionnel,
                EstActif = value.EstActif,
                DateCreation = value.DateCreation,
                DateModification = value.DateModification
            };
        }

        public static Employe ToRequest(this UpdateEmployeCommand value)
        {
            return new Employe(value.Id,value.Matricule, value.Nom, value.Prenom, value.Email, value.TelephoneProfessionnel, value.TelephonePersonnel);
        }

    }
}
