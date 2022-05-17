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
        public class ProducerManager : IProducerService
        {
            IProducerDal _producerDal;

            public ProducerManager(IProducerDal producerDal)
            {
                _producerDal = producerDal;
            }

            public void Add(Producer producer)
            {
                _producerDal.Add(producer);
            }

            public void Delete(Producer producer)
            {
                _producerDal.Delete(producer);
            }

            public List<Producer> GetAll()
            {
                return _producerDal.GetAll();
            }

            public Producer GetById(int id)
            {
                return _producerDal.Get(p=>p.ProducerId==id);
            }

            public void Update(Producer producer)
            {
                _producerDal.Update(producer);
            }
        }
    }

