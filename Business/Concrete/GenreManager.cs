using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GenreManager : IGenreService
    {

        IGenreDal _genreDal;

        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }

        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public void Delete(Genre genre)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            return _genreDal.GetAll();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
    
}
