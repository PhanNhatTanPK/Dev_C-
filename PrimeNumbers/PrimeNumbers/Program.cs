using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1, numhalf, divisor, prime=0;
            bool isprime = true;
            Console.WriteLine("The first 10 prime numbers are: ");
            while(prime<10)
            {
                num += 1;
                numhalf = num / 2;
                divisor = 2;
                while(numhalf >= divisor)
                {
                    if(num % divisor ==0)
                    {
                        isprime = false;
                        break;
                    }
                    divisor += 1;
                }
                if (isprime == true)
                {
                    prime++;
                    Console.Write("{0}   ", num);
                }
                else
                    isprime = true;
            }
            Console.ReadLine();
        }
    }
}
