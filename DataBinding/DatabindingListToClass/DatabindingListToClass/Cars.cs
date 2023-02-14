using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingListToClass
{
    internal class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car() { Owner = "Mike", Type = CarType.Sedan, Brand = CarBrand.VW},
                new Car() { Owner = "Warson", Type = CarType.Suv, Brand = CarBrand.BMW },
                new Car() { Owner = "Clark", Type = CarType.Hatchaback, Brand = CarBrand.Mercedes },
            }.ToList();
        }
    }
}
