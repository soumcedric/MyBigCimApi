using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Demande
{
    public class AddDemandeCommand
    {
        public Guid EmployeId { get; set; }
        public TypeDemande TypeDemande { get; set; }
        public DateOnly DateDebut { get; set; }
        public DateOnly DateFin { get; set; }
        public string Commentaire { get; set; }


    }
}
