using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            //取出100個不重複之數字
            int count = 1;
            while (count <= 100)
            {
                int num = random.Next(1, 200);
                if (list.Contains(num) == false)
                {
                    list.Add(num);
                    count++;
                }

            }
            Console.WriteLine("Original List:");
            //print Original List
            foreach (var item in list)
            {
                Console.Write(string.Format("{0}, ", item));
            }
            Console.WriteLine("");
            Console.WriteLine("");


            list.Sort();
            Console.WriteLine("Sorted List");
            //print Sorted List
            foreach (var item in list)
            {
                Console.Write(string.Format("{0}, ", item));
            }

            Console.ReadLine();
        }
    }
}
