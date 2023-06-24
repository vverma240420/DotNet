using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal class Addition
    {
        public int DoAddition()
        {
            int a = 2;
            int b = 4;
            int result = a + b;
            Console.WriteLine("Addition is :" +result);
            return result;
            
        }

        public double DoSubtraction()
        {
            double x= 15.5;
            double y= 3.2;
            double result = x - y;
            Console.WriteLine("Subtraction is :"+result);
            return result;
        }

        public String DoMethod()
        {
            string s1 = "Abhi";
            string s2 = "Patel";
            string fullName = s1+ s2;
            Console.WriteLine(fullName);
            return fullName;
        }
    }
}
