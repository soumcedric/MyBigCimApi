using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class EmployeFonction:EntityBase
    {
        public Fonction Fonction { get; set; }
        public Employe Employe { get; set; }
        public Service Service { get; set; }
    }
}
