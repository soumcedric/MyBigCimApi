using Application.Command;
using Application.Dtos;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    internal static class FonctionMapper
    {
        public static List<FonctionDto> ToDtos(this List<Fonction> value)
        {
            List<FonctionDto> fonctions = new List<FonctionDto>();

            value.ForEach(x =>
            {
                fonctions.Add(new FonctionDto
                {
                    //Id = x.Id,
                    Code = x.Code,
                    Libelle = x.Libelle
                });
            });

          return fonctions;

        }
    }
}
