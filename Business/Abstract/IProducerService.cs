using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProducerService
    {
        List<Producer> GetAll();
        Producer GetById(int id);
        void Add(Producer producer);
        void Delete(Producer producer);
        void Update(Producer producer);
    }
}

