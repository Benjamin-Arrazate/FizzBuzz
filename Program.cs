using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            int x = 0;

            for(int i = 0;i<100;i++)
            {
                x = i + 1;

                numeros[i] = x;
                
            }
            
            for(int i = 0;i<numeros.Length;i++)
            {

                int mod3 = (numeros[i] % 3);
                int mod5 = (numeros[i] % 5);

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
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}
