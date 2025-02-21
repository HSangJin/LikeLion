using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("□□□□□□□□□");
            //Thread.Sleep(1000); // 1000 = 1초 (1000 밀리초)
            //Console.Clear(); //콘솔 화면 지우기
            ////Console.WriteLine("                  ");
            ////Thread.Sleep(3000);
            ////Console.Clear();
            //Console.WriteLine("■□□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■□□□□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■■□□□□□□");
            //Thread.Sleep(1000);
            //Console.WriteLine("■■■■□□□□□");
            //Thread.Sleep(1000);
            //Console.WriteLine("■■■■■□□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■■■■■□□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■■■■■■□□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■■■■■■■□");
            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("■■■■■■■■■");

            int index = 0;
            const int count = 10;
            bool isReverse = false;
            while (true)
            {
                if(isReverse == false)
                {
                    while(count >= index)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j < index)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("□");
                            }
                        }
                        index += 1;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    isReverse = true;
                }
                else
                {
                    while(index>0)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (j < index)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("□");
                            }
                        }
                        index -= 1;
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    isReverse = false;
                }
            }
        }
    }
}
