using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Core
//{
    public abstract class EntityBase
    {
        public Guid Id { get;  set; }
        public DateTime DateCreation {  get;  set; }
        public Guid UtilisateurCreation { get;   set; }
        public DateTime DateModification { get;  set; }
        public Guid UtilisateurModification { get;  set; }
        public bool EstActif {  get;  set; }
    }
//}
