using System;
using System.Text;
using System.Globalization;

namespace PRACTICE
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("enter your first number");
        int number1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("enter your second number");
        int number2 = Convert.ToInt32(Console.ReadLine());
      

         int totalNumber3 = number1 + number2;
         int totalNumber4 = (number1 - number2);
         int totalNumber5 = (number1 * number2);
         int totalNumber6 = (number1 / number2);

        Console.WriteLine("your first number is:{0} ", totalNumber3);
       
        Console.WriteLine("your second number is:{0} ", totalNumber4);
        
        Console.WriteLine("your third number is:{0} ", totalNumber5);
    
        Console.WriteLine("your fourth number is:{0} ", totalNumber6);

        }


    }
}


