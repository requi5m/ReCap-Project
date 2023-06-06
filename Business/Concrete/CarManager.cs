using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.InMemoryCache;
using Entities.Abstract;
using Entities.Concrete;

namespace Business
{
    public class CarManager:InMemoryDal
    {
        ICarDal _productDal;
        private InMemoryDal ınMemoryDal;

        public void GetAll(ICarDal carDal)
        {
            _productDal = carDal;
        }

        List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

    }
}
