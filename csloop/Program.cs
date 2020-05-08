using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks; //내부적으로 흐른 시간
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count);
            Console.WriteLine();


            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(String item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



        }
    }
}
