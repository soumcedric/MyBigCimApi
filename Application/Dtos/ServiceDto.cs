using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ServiceDto
    {
        public Guid Id { get; set; }
        public string Libelle { get; set; }
        public string Code { get; set; }
        public bool EstArchive { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public Guid UtilisateurCreation {  get; set; }
        public Guid UtilisateurModification { get; set; }
    }
}
