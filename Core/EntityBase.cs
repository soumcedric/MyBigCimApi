using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class EntityBase
{
    public Guid Id { get; set; }
    public DateTime DateCreation { get; set; }
    public Guid UtilisateurCreation { get; set; }
    public DateTime DateModification { get; set; }
    public Guid UtilisateurModification { get; set; }
    public bool EstActif { get; set; }

    public EntityBase()
    {
        Id = Guid.NewGuid();
        DateCreation = DateTime.Now;
        UtilisateurCreation = Guid.NewGuid();
        EstActif = true;
    }

    public void Update()
    {
        DateModification = DateTime.Now;
        UtilisateurModification = Guid.NewGuid();
    }

    public void Delete()
    {
        DateModification = DateTime.Now;
        EstActif = false;

    }


}

