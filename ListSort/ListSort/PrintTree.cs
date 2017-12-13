using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort
{
    class PrintTree
    {
        static void Main(string[] args)
        {
            Console.Write("Input Height of the tree:");
            string input = Console.ReadLine();
            int n = 0;

            if (int.TryParse(input, out n) == true)
            {
                for (int i = 1; i <= n; i++)
                {
                    // Method 1: double For
                    // 
                    // for (int j = 1; j <= n - i; j++)
                    //   {
                    //       Console.Write(" ");
                    //   }
                    //   for (int k = 1; k <= 2 * i - 1; k++)
                    //   {
                    //       Console.Write("*");
                    //}
                    
                    // Method 2: new String
                    Console.WriteLine(new String(' ', n-i) + new String('*', 2*i - 1));
                }
            }
            else
            {
                Console.WriteLine("Wrong input! please check again.");
            }
            Console.ReadLine();


        }
    }
}
