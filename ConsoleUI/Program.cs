using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

           
            Console.WriteLine("******************* LİSTELE *********************************");
            

            Console.WriteLine("ID--BRANDID--COLORID -- DAILYPRICE -- MODELYEAR --DESCRIPTION");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0},\t{1},\t{2},\t {3},\t \t{4}, \t {5}", car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.ModelYear, car.Description);
            }
       

            Console.WriteLine("******************* EKLE-SİL-GÜNCELLE *********************************");
            

            carManager.Add(new Car { Id = 5, BrandId = 2, ColorId = 2, DailyPrice = 300, ModelYear = 2020, Description = "tiptronic dizel" });
            Console.WriteLine("Kayıt Eklendi");

            carManager.Delete(2);
            Console.WriteLine("Kayıt Silindi");


            Car update = new Car { Id = 4, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 200, Description = "Manuel vites benzinli" };
            carManager.Update(update);
            Console.WriteLine("Kayıt Güncellendi");


            Console.WriteLine("********************ID'ye GÖRE GETİR**************************");
            
            Console.WriteLine("ID--BRANDID--COLORID -- DAILYPRICE -- MODELYEAR --DESCRIPTION");

            Car carById = carManager.GetById(3);
            Console.WriteLine("{0},\t{1},\t{2},\t {3},\t \t{4}, \t {5}", carById.Id, carById.BrandId, carById.ColorId, carById.DailyPrice, carById.ModelYear, carById.Description);





        }
    }
}
