using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPLab1
{
    internal class FordWebShopFactory : IWebShopFactory
    {
        public ICarFactory GetCarFactory()
        {
            return new SUVFactory();
        }
    }

}
