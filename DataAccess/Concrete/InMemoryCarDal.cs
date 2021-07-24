using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                //brand = marka *** description = tanım *** renkler sırasıyla /1-beyaz /2-siyah /3-gri /4-mavi /5-kırmızı 
                new Car { Id = 1,  BrandId = 1, ColorId = 1, ModelYear = 1968, Description = "Klasik Araç",    DailyPrice = 1975000 },
                new Car { Id = 2,  BrandId = 1, ColorId = 2, ModelYear = 2001, Description = "İkinci El Araç", DailyPrice =  193000 },
                new Car { Id = 3,  BrandId = 1, ColorId = 3, ModelYear = 2021, Description = "Sıfır Araç",     DailyPrice = 3550000 },
                new Car { Id = 4,  BrandId = 2, ColorId = 4, ModelYear = 1972, Description = "Klasik Araç",    DailyPrice =  115000 },
                new Car { Id = 5,  BrandId = 2, ColorId = 5, ModelYear = 1984, Description = "İkinci El Araç", DailyPrice =   70000 },
                new Car { Id = 6,  BrandId = 3, ColorId = 1, ModelYear = 2021, Description = "Sıfır Araç",     DailyPrice = 2325000 },
                new Car { Id = 7,  BrandId = 3, ColorId = 2, ModelYear = 2012, Description = "İkinci El Araç", DailyPrice =  246500 },
                new Car { Id = 8,  BrandId = 3, ColorId = 3, ModelYear = 1955, Description = "Klasik Araç",    DailyPrice =  210000 },
                new Car { Id = 9,  BrandId = 3, ColorId = 4, ModelYear = 1990, Description = "İkinci El Araç", DailyPrice =   55000 },
                new Car { Id = 10, BrandId = 4, ColorId = 5, ModelYear = 1970, Description = "Klasik Araç",    DailyPrice =   24750 },

            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car _carToDelete = _cars.SingleOrDefault(car => car.Id == car.Id);
            _cars.Remove(_carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
