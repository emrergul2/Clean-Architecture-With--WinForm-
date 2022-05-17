using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStarService
    {
        List<Star> GetAll();
        Star GetById(int id);
        void Add(Star star);
        void Delete(Star star);
        void Update(Star star);
    }
}

