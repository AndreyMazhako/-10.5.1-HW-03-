using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_10._5._1__HW_03;

// Реализация интерфейса IAdder
class Adder : IAdder
{
    public double Add(double a, double b)
    {
        return a + b;
    }
}
