using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Max");
            int Max=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            for(int number = int.Parse(Console.ReadLine()); number <= Max; number++)
            {
                int sum = 0;
                for(int i =1; i<=number; i++)
                {
                    
                    if(number % i ==0)
                    {
                        sum++;
                    }
                } 
                if(sum == 2)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadKey();  
        }
    }
}
