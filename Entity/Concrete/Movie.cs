using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Movie:IEntity
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public decimal Revenue { get; set; }
        public string ReleaseDate { get; set; }
    }
}
