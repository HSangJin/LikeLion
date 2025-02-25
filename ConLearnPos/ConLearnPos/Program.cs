using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConLearnPos
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 80, height = 25;
            //콘솔 창 크기 설정
            Console.SetWindowSize(width, height);

            //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(width, height);

            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Magenta;

            //
            Console.CursorVisible = false; //커서 숨기기

            Console.Clear();

            

            //Console.SetCursorPosition(40, 12);

            //Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            //Console.ReadLine();

            Console.SetCursorPosition(0, 0);
            for(int i=0;i<=width-1;i++)
            {
                Console.SetCursorPosition(i, 0);
                if (i == 0)
                    Console.Write("┏");
                else if (i == width-1)
                    Console.Write("┓");
                else
                    Console.Write("━");
                //Thread.Sleep(1);
            }
            for(int i = 1; i < height-1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("┃");
                //Thread.Sleep(1);
                Console.SetCursorPosition(width-1, i);
                Console.Write("┃");
                //Thread.Sleep(1);
            }
            for (int i = 0; i <= width - 1; i++)
            {
                Console.SetCursorPosition(i, height-1);
                if (i == 0)
                    Console.Write("┗");
                else if (i == width - 1)
                    Console.Write("┛");
                else
                    Console.Write("━");
                //Thread.Sleep(1);
            }

            Thread.Sleep(3000);

            for(int x = 0; x<30;x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);
            }
        }
    }
}
