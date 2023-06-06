using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using DataAccess.InMemoryCache;
using Entities.Concrete;

namespace ConsoleUIs
{
    public class Program:CarManager
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }       
    }
}
