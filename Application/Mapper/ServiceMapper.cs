using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Application.Command;
using Core.Entity;

namespace Application.Mapper
{
    internal static class ServiceMapper
    {
        public static Service ToRequest(this ServiceCmd value)
        {
            Service service= new(value.Libelle, value.Code);
            return service;
        }
    }
}
