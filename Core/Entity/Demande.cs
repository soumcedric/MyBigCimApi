using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Demande:EntityBase
    {
        public StatutDemande Statut { get; private set; }
        public EmployeFonction EmployeFonction { get; private set; }
        public TypeDemande TypeDemande { get; private set; }
    }
}
