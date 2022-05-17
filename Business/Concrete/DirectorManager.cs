using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DirectorManager : IDirectorService
    {
        IDirectorDal _directorDal;

        public DirectorManager(IDirectorDal directorDal)
        {
            _directorDal = directorDal;
        }

        public void Add(Director director)
        {
            _directorDal.Add(director);
        }

        public void Delete(Director director)
        {
            _directorDal.Delete(director);
        }

        public List<Director> GetAll()
        {
            return _directorDal.GetAll();
        }

        public Director GetById(int id)
        {
            return _directorDal.Get(d => d.DirectorId == id);
        }

        public void Update(Director director)
        {
            _directorDal.Update(director);
        }
    }
}
