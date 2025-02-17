using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.EmployeFonction
{
    public class AddEmployeFonctionCommand
    {
        public Guid EmployeId { get; set; }
        public Guid FonctionId { get; set; }
        public Guid ServiceId { get; set; }
        public string Matricule { get; set; }
        // public DateTime DateDebut { get; set; }

    }
}
