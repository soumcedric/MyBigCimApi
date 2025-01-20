using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ObjectResponse<TObject>  where TObject : class
    {
       public IEnumerable<TObject> Response { get; set;  }
       public string Message { get; set; }
    }
}
