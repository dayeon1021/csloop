using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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


            int x = 1;
            while (x < 50)
            {
                Console.Clear();
            }
            */
            /*
            //예제 02
            int[] intarray = new int[10];
            foreach(var item in intarray)
            {
                Console.WriteLine(item);
            }
            */
            /*
            //예제 3
            int[] array = new int[20];
            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = int[] { 1,2,3};
            int[] array4 = { 1, 2, 3 };
            */
            /*
            //예제 4
            for(int i = 0; i < 20; i = i + 2)
            {
                Console.WriteLine("출력");
            }
            */
            //예제 5
            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("출력");
                i++;
            }
            */
            /*
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
            }
            */
            /*
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch(info.Key){
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:                        
                        break;
                }
            }
            */
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }

        }
    }
}
