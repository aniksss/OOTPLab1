using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPLab1
{
    internal class WebShop
    {
        private readonly IWebShopFactory _factory;

        public WebShop(IWebShopFactory factory)
        {
            _factory = factory;
        }

        public void SellCar()
        {
            var carFactory = _factory.GetCarFactory();
            var car = carFactory.CreateCar();
            Console.WriteLine($"Car sold: {car.Make} - {car.Model}: {car.Year}");

            // sell the car to the customer
        }
    }

}
