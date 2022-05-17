using Core.DataAccess.EntityFramework;
using Entity.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EntityRepositoryBase<User, MMSContext>, IUserDal
    {
    }
}
