using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Validations:EntityBase
    {
        public Employe EmployeValidateur { get; private set; }
        public Demande Demande { get; private set; }
        public StatutValidation Statut { get; private set; }
        public string Commentaire { get; private set; }
        public DateTime DateValidation { get; private set; }

    }
}
