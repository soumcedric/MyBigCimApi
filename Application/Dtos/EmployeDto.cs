using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class EmployeDto
    {
        public Guid Id { get; set; }
        public string? Nom { get;  set; }        
        public string? Prenom { get;  set; }        
        public string? Telephone { get; set; }        
        public string? Matricule { get;  set; }        
        public string? Email { get;  set; }        
        public string? TelephoneProfessionnel { get;  set; }
        public bool EstActif { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
    }
}
