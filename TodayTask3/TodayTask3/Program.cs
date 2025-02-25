using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask3
{
    class Program
    {
        static int width = 80, height = 25;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            SetFrame();
            CenterText(new string[] { "졸라멘 총알 피하기!", "아무키나 눌러 게임 시작!"}, 0.03, 0.3);
            Console.ReadKey();

            for(int i=3;i>0;i--)
            {
                Console.Clear();
                SetFrame();
                CenterText(new string[] { $"{i}" });
                Thread.Sleep(1000);
            }

            Play();
        }

        static void TextAnimation(string text, double delay = 0, double endDelay = 0)
        {
            int _delay = (int)Math.Floor(delay * 1000);
            for(int i =0;i<text.Length;i++)
            {
                Console.Write(text.Substring(i, 1));
                Thread.Sleep(_delay);
            }

            int _endDelay = (int)Math.Floor(endDelay * 1000);
            Thread.Sleep(_endDelay);
        }

        static void CenterText(string[] text, double delay = 0, double endDelay = 0)
        {
            for(int i=0;i<text.Length;i++)
            {
                Console.SetCursorPosition(width / 2 - text[i].Length, height/2 - text.Length / 2+i);
                TextAnimation(text[i], delay / text[i].Length, endDelay / text[i].Length);
            }
        }

        static void SetFrame()
        {
            for(int i=0;i<width;i++)
            {
                Console.SetCursorPosition(i, 0);
                if (i == 0)
                    Console.Write("┏");
                else if (i == width-1)
                    Console.Write("┓");
                else
                    Console.Write("━");
            }

            for(int i=1;i<height-1;i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("┃");
                Console.SetCursorPosition(width-1, i);
                Console.Write("┃");
            }

            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, height-1);
                if (i == 0)
                    Console.Write("┗");
                else if (i == width - 1)
                    Console.Write("┛");
                else
                    Console.Write("━");
            }

            Console.SetCursorPosition(1, 1);
        } 

        static void Play()
        {
            int stickmanX = 5, stickmanY = 10;
            int bulletX, bulletY;
            Random rand = new Random();
            bool running = true;
            int dodgeCount = 0;

            Console.CursorVisible = false;

            Thread inputThread = new Thread(() =>
            {
                while (running)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow && stickmanY > 1)
                        stickmanY--;
                    else if (key == ConsoleKey.DownArrow && stickmanY < height - 4)
                        stickmanY++;
                }
            });
            inputThread.Start();

            while (running)
            {
                // 총알 초기 위치 설정 (랜덤 높이에서 발사)
                bulletX = width - 2;
                bulletY = rand.Next(5, height - 5);

                for (; bulletX > 0; bulletX--)
                {
                    Console.Clear();
                    SetFrame();
                    // 졸라멘 이동 (위아래 반복 움직임)
                    //stickmanY = (stickmanY == 10) ? 12 : 10;

                    // 졸라멘 출력
                    Console.SetCursorPosition(stickmanX+1, stickmanY);
                    Console.Write("O");
                    Console.SetCursorPosition(stickmanX, stickmanY + 1);
                    Console.Write("/|\\");
    
                    Console.SetCursorPosition(stickmanX, stickmanY + 2);
                    Console.Write("/ \\");

                    // 총알 출력
                    Console.SetCursorPosition(bulletX, bulletY);
                    Console.Write("-");

                    // 충돌 검사
                    if (bulletX == stickmanX && bulletY >= stickmanY && bulletY <= stickmanY + 2)
                    {
                        running = false;
                    }

                    Thread.Sleep(5);
                }

                dodgeCount++;
                if (dodgeCount >= 5)
                {
                    DanceAnimation();
                    dodgeCount = 0;
                    break;
                }
            }

            inputThread.Join();

            // 게임 오버 메시지
            Console.Clear();
            SetFrame();
            CenterText(new string[] { "게임오버!", "아무키나 눌러 게임 종료..." }, 0.1, 0.3);
            Console.ReadKey();
        }

        static void DanceAnimation()
        {
            string[] danceMoves =
        {
            "\n\t O \n\t/|\\ \n\t/ \\",
            "\n\t O/ \n\t/|  \n\t/\\",
            "\n\t\\O/\n\t |  \n\t/ \\",
            "\n\t O \n\t/|\\ \n\t/ \\",
            "\n\t O  \n\t/|\\ \n\t/\\",
            "\n\t\\O/\n\t |  \n\t/ \\",
            "\n\t O \n\t/|/ \n\t/\\",
            "\n\t O  \n\t/| \\ \n\t/ \\",
            "\n\t O/ \n\t/|  \n\t / \\",
            "\n\t O  \n\t/|  \n\t / \\"
        };

            bool isBreak = false;
            Thread input = new Thread(() =>
            {
                if(Console.KeyAvailable)
                    isBreak = true;
            });

            input.Start();

            int i = 0;
            while (!isBreak)
            {
                Console.Clear();
                SetFrame();
                Console.SetCursorPosition(5, 10);
                Console.WriteLine(danceMoves[i % danceMoves.Length]);
                Thread.Sleep(100);
                i+=1;
            }

            input.Join();
        }
    }
}
