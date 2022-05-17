using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Genre:IEntity
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
