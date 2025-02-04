using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public string Telephone { get; private set; }
        [Column(TypeName = "Varchar(15)")]
        public string Matricule { get; private set; }
        [Column(TypeName = "Varchar(50)")]
        public string Email { get; private set; }
        [Column(TypeName = "Varchar(15)")]
        public string TelephoneProfessionnel { get; private set; }

        public Employe()
        {
            
        }

        public Employe(string nom, string prenom, string telephone, string matricule, string email, string telephoneProfessionnel)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Matricule = matricule;
            Email = email;
            TelephoneProfessionnel = telephoneProfessionnel;
        }

        public Employe(Guid id, string nom, string prenom, string telephone, string matricule, string email, string telephoneProfessionnel)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Matricule = matricule;
            Email = email;
            TelephoneProfessionnel = telephoneProfessionnel;
        }

        public void Modifier(Guid id, string nom, string prenom, string telephone, string matricule, string email, string telephoneProfessionnel)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Matricule = matricule;
            Email = email;
            TelephoneProfessionnel = telephoneProfessionnel;
        }

        
    }
}
