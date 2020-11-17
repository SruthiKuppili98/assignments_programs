using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Createservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculation" in both code and config file together.
    public class Calculation : ICalculation
    {
        public int sum(int num1, int num2)
        {
        return num1+num2;
        }
        public int Subtract(int num1,int num2)

        {
            return num1 - num2;
        }
       public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divison(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}