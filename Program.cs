using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // int age = 38;
            // string name = "Iwata";
            // bool iamStudyng = true;
            // decimal price = 20.00M;
            // var city = "Nagoya";
            
            // Console.WriteLine(name);
            // Console.WriteLine(age);
            // Console.WriteLine(iamStudyng);
            // Console.WriteLine(price);
            // Console.WriteLine(city);

            int stock = 2;
            decimal priceUnit = 19.90m;
            decimal total = stock * priceUnit;
            
            //////If Else///////////////////
            // stock += 1;

            // bool stockLow = stock < 5;
            // bool priceHigh = priceUnit >= 20.0m;
            // bool danger  = stockLow && !priceHigh;

            // Console.WriteLine(total);
            // Console.WriteLine(stock);
            // Console.WriteLine(stockLow);
            // Console.WriteLine(priceHigh);
            // Console.WriteLine(danger);

            //////Switch//////////////////////
            // int codStatus = 2;

            // switch(codStatus)
            // {
            //     case 1:
            //         Console.WriteLine("No paymented.");
            //         break;
            //     case 2:
            //         Console.WriteLine("Paymented");
            //         break;
            //     case 3:
            //         Console.WriteLine("Cancel");
            //         break;
            //     default:
            //         Console.WriteLine("Not status");
            //         break;
            // }

            ////////////Loops While and For/////////////
            int count = 1;

            while(count <= 3)
            {
                Console.WriteLine(count);
                count++;
            }

            Console.WriteLine("");

            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);    
            }
            

        }
    }
}