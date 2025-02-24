using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class DemandeDto
    {
        public Guid Id { get; set; }
        public EmployeDto Employe { get; set; }
        public StatutDemande Statut { get; set; }
        public DateOnly DateDebut { get; set; }
        public DateOnly DateFin { get; set; }
        public TypeDemande TypeDemande { get; set; }
    }
}
