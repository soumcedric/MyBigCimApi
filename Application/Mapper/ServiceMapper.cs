using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Application.Command;
using Application.Dtos;
using Core.Entity;

namespace Application.Mapper
{
     static class ServiceMapper
    {
        public static Service ToRequest(this ServiceCmd value)
        {
            Service service= new(value.Libelle, value.Code);
            return service;
        }

        public static ServiceDto ToDto(this Service value)
        {
            ServiceDto service = new()
            {
                Id = value.Id,
                Code = value.Code,
                Libelle = value.Libelle
            };
            return service;
        }


    }
}
