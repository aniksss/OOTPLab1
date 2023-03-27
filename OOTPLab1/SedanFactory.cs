using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPLab1
{
    internal class SedanFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new Sedan();
        }
    }

}
