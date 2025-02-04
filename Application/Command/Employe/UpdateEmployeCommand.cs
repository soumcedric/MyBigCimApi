using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Employe
{
    public class UpdateEmployeCommand
    {
        public Guid Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string TelephoneProfessionnel { get; set; }
        public string TelephonePersonnel { get; set; }
    }
}
