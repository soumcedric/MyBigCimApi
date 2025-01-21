using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Fonction:EntityBase
    {
        [Column(TypeName = "Varchar(50)")]
        public string Libelle {  get; private set; }
        [Column(TypeName = "Varchar(20)")]
        public string Code {  get; private set; }

        public Fonction()
        {
            
        }

        public Fonction(string libelle, string code)
        {
            Libelle = libelle;
            Code = code;
        }



    }
}
