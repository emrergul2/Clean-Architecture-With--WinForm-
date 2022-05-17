using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Star:IEntity
    {
        public int StarId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
