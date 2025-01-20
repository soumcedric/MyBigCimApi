using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class TypeDemande:EntityBase
    {
        [Column(TypeName = "Varchar(50)")]
        public string Libelle { get; private set; }
    }
}
