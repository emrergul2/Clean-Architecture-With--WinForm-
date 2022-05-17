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
        public class StarManager : IStarService
        {
            IStarDal _starDal;

            public StarManager(IStarDal starDal)
            {
                _starDal = starDal;
            }
            public void Add(Star star)
            {
                _starDal.Add(star);
            }

            public void Delete(Star star)
            {
                _starDal.Delete(star);
            }

            public List<Star> GetAll()
            {
                return _starDal.GetAll();
            }

            public Star GetById(int id)
            {
                return _starDal.Get(s => s.StarId == id);
            }

            public void Update(Star star)
            {
                _starDal.Update(star);
            }
        }
    
}
