using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenreService
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        void Add(Genre genre);
        void Delete(Genre genre);
        void Update(Genre genre);
    }
}
