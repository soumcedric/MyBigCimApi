using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Employe:EntityBase
    {
     
        [Column(TypeName ="Varchar(50)")]
        public string Nom { get; private set; }
        [Column(TypeName = "Varchar(50)")]
        public string Prenom { get; private set; }
        [Column(TypeName = "Varchar(15)")]
        public DateTime Telephone { get; private set; }


    }
}
