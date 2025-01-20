using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Service:EntityBase
    {
        [Column(TypeName = "Varchar(50)")]
        public string Libelle { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Code { get; set; }


        public Service(string libelle, string code)
        {
            Libelle  = libelle;
            Code = code;
        }

    }
}
