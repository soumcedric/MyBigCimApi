using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.Demande
{
    public class GetDemandesByEmployeQuery
    {
        public Guid EmployeId { get; set; }
        public TypeDemande TypeDemande { get; set; }
    }
}
