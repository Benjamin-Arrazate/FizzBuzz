using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            
            for(int i = 1;i<=100;i++)
            {

                int mod3 = (i % 3);
                int mod5 = (i % 5);

                if(mod3==0 && mod5==0)
                {  
                    Console.WriteLine("FizzBuzz");
                }
                else if(mod3==0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(mod5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
