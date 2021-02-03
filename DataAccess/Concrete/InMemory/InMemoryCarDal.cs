using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {


            _cars = new List<Car> {

                new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2017, DailyPrice=150, Description="Benzinli otomatik vites"},
                new Car {Id=2, BrandId=2, ColorId=2, ModelYear=2014, DailyPrice=125, Description="Benzinli manuel vites"},
                new Car {Id=3, BrandId=2, ColorId=1, ModelYear=2018, DailyPrice=225, Description="Dizel otomatik vites"},
                new Car {Id=4, BrandId=3, ColorId=2, ModelYear=2017, DailyPrice=150, Description="Benzinli otomatik vites"}
                };
            
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.SingleOrDefault(x=> x.Id==id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(x => x.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
