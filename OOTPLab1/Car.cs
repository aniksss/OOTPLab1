using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPLab1
{
    internal abstract class Car
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract int Year { get; }
    }

}
