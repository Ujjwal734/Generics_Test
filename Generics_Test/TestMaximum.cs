using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Test
{
    public class TestMaximum
    {
        public int MaximumNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                // Console.WriteLine("FirstNumber is Greater...! ");
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                // Console.WriteLine("Second Number is Greater...! ");
                return secondNumber;
            }
            else
            {
                //Console.WriteLine("Third Number is Greater...! ");
                return thirdNumber;
            }
        }
    }
}
