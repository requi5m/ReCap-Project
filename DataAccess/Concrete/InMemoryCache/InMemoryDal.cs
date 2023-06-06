using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.InMemoryCache
{
    public class InMemoryDal:ICarDal
    {
        List<Car> _cars = new List<Car>
        {
            new Car{Id = 1, CategoryId=2, Name="Dacia", UnitsInPrice = 100000, UnitsInStock = 5},
            new Car{Id = 2, CategoryId=3, Name="Wolkswagen", UnitsInPrice = 90000, UnitsInStock = 4},
            new Car{Id = 3, CategoryId=3, Name="Renault", UnitsInPrice = 80000, UnitsInStock = 3},
            new Car{Id = 4, CategoryId=2, Name="Fiat", UnitsInPrice = 70000, UnitsInStock = 2}

        };

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CategoryId == car.CategoryId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where(p => p.CategoryId == categoryId).ToList();
        }       

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CategoryId == car.CategoryId);
            carToUpdate.Name = car.Name;
            carToUpdate.UnitsInPrice = car.UnitsInPrice;
            carToUpdate.UnitsInStock = car.UnitsInStock;
        }
    }
}
