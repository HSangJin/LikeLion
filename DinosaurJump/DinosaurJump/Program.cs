using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DinosaurJump
{
    [StructLayout(LayoutKind.Sequential)]
    public struct COORD
    {
        public short X;
        public short Y;
    }

    public struct Vector2
    {
        public int x, y;

        public Vector2(int value)
        {
            x = value;
            y = value;
        }

        public Vector2(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 Zero() { return new Vector2(0); }

        public static Vector2 One() { return new Vector2(1); }
    }

    public class Player
    {
        public static Player instance;
        public Vector2 playerSize = new Vector2(20, 6);
        Vector2 oriPos;
        public Vector2 pos { get; private set; }
        public int jumpPower { get; private set; } = 4;
        public int jumpState { get; private set; } = 0;
        static string[][] player =
        {
                new string[] {
                    "                   __",
                    "                 / *_)  ",
                    "      _.----. _ /../",
                    "    /............./",
                    "__/..(...|.(...|",
                    "/__.-|_|--|_|"
                },
                new string[] {
                    "                   __",
                    "                 / *_)  ",
                    "      _.----. _ /../",
                    "    /............./",
                    "__/..(...|.(...|",
                    "/__.-|_|---|_|"
                },
                new string[] {
                    "                   __",
                    "                 / *_)  ",
                    "      _.----. _ /../",
                    "    /............./",
                    "__/..(...|.(...|",
                    "/__.--|_|-|_|"
                }
            };
        int playerIndex = 0;
        int drawMax;
        int drawCounter = 0;
        public List<Vector2> colider = new List<Vector2>();

        public List<char> whiteList { get; private set; } = new List<char>();

        public Player(Vector2 startPos, int jumPower, int drawCount = 1)
        {
            instance = this;

            Vector2 _pos = startPos;
            _pos.y -= playerSize.y;

            this.pos = _pos;
            oriPos = _pos;
            this.jumpPower = jumPower;
            this.drawMax = drawCount;

            for(int i=0;i<player.Length;i++)
            {
                for(int j = 0; j < player[i].Length;j++)
                {
                    for(int k = 0; k < player[i][j].Length;k++)
                    {
                        string s = player[i][j].Substring(k,1);
                        char c = char.Parse(s);
                        if (!whiteList.Contains(c))
                            whiteList.Add(c);
                    }
                }
            }
        }

        public void Jump()
        {
            if (jumpState != 0)
                return;
            jumpState = 1;
        }

        public void Draw()
        {
            Vector2 _pos = pos;
            if (jumpState == 1)
            {
                _pos.y--;
                if (oriPos.y - _pos.y >= jumpPower)
                    jumpState = -1;
            }
            else if (jumpState == -1)
            {
                if (drawCounter < drawMax)
                {
                    drawCounter += 1;
                }
                else
                {
                    drawCounter = 0;
                    _pos.y++;
                    if (_pos.y >= oriPos.y)
                        jumpState = 0;
                }
                    
            }


            colider.Clear();
            for (int i = 0; i < player[playerIndex].Length; i++)
            {
                for (int j = 0; j < player[playerIndex][i].Length; j++)
                {
                    Console.SetCursorPosition(_pos.x + j, _pos.y + i);
                    Console.Write(player[playerIndex][i].Substring(j, 1));
                    colider.Add(new Vector2(_pos.x + j, _pos.y + i));
                }
            }

            playerIndex +=1;
            if (playerIndex >= player.Length)
                playerIndex = 0;

            pos = _pos;
            Game.instance.score += 1;
        }
    }

    public class Hurdle
    {
        Vector2 pos;
        public enum hurdle { bird, cactus };
        hurdle type;
        public int score { get; private set; }
        string[] bird =
        {
            "╭─╮",
            "╰^╯"
        };
        string[] cactus =
        {
            "┤││├",
            "││││"
        };
        public List<Vector2> colider { get; private set; } = new List<Vector2>();
        int drawMin, drawMax, drawSpawn = -1, drawCounter = 0; 
        public bool isActive {get; private set;}

        public Hurdle(hurdle type)
        {
            this.type = type;
            this.score = type == hurdle.cactus ? 50 : type == hurdle.bird ? 30 : 0;
            
            drawMax = type == hurdle.cactus ? 30 : type == hurdle.bird ? 50 : 30;
            drawMin = type == hurdle.cactus ? 10 : type == hurdle.bird ? 15 : 5;

            Set();
        }

        public void Set()
        {
            Random rand = new Random();
            if (drawSpawn < 0)
                drawSpawn = rand.Next(drawMin, drawMax);

            if (drawCounter >= drawSpawn)
            {
                drawSpawn = rand.Next(drawMin, drawMax);
                drawCounter = 0;
                Vector2 pos = new Vector2();
                pos.x = Game.instance.screen.x;
                pos.y = type == hurdle.cactus ? Game.instance.screen.y - 5 :
                    type == hurdle.bird ? Game.instance.screen.y - rand.Next(6, Player.instance.playerSize.y + Player.instance.jumpPower) : Game.instance.screen.y - 2;
                this.pos = pos;
            }
            else
            {
                drawCounter += 1;
                isActive = false;
            }
        }

        public void Draw()
        {
            Vector2 _pos = pos;
            _pos.x--;
            if (_pos.x <= (type == hurdle.cactus ? 0 : type == hurdle.bird ? -1 : 0))
            {
                if(isActive == true)
                    Game.instance.score += score;
                
                Set();
                return;
            }

            colider.Clear();
            switch (type)
            {
                case hurdle.bird:
                    for(int i=0;i<bird.Length;i++)
                    {
                        for(int j = 0; j < bird[i].Length;j++)
                        {
                            if (Game.instance.screen.x <= _pos.x + j || _pos.x +j == 0)
                                break;
                            Console.SetCursorPosition(_pos.x+j, _pos.y + i);
                            Console.Write(bird[i].Substring(j, 1));

                            colider.Add(new Vector2(_pos.x+j, _pos.y+i));
                        }

                    }
                    break;
                case hurdle.cactus:
                    for (int i = 0; i < cactus.Length; i++)
                    {
                        for(int j=0; j < cactus[i].Length; j++)
                        {
                            if(Game.instance.screen.x <= _pos.x+j || _pos.x +j == 0)
                                break;
                            Console.SetCursorPosition(_pos.x+j, _pos.y + i);
                            Console.Write(cactus[i].Substring(j,1));

                            colider.Add(new Vector2(_pos.x + j, _pos.y + i));
                        }
                    }
                    break;
            }

            pos = _pos;
        }
    }

    public class Game
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        public static Game instance;
        public enum GameType { loading, gaming, over };
        public GameType type;
        public int score;
        public Vector2 screen { get; private set; }
        public int ground { get; private set; }
        public int gameRate {get; private set;}
        public Player player { get; private set; }
        public List<Hurdle> hurdles { get; private set; } = new List<Hurdle>();
 

        public Game(Vector2 screen, int groundHeight, int gameRate)
        {
            Console.OutputEncoding = Encoding.UTF8;

            instance = this;
            type = GameType.loading;
            score = 0;
            this.screen = screen;
            this.ground = groundHeight;
            this.gameRate = gameRate;

            player = new Player(startPos: new Vector2(1, screen.y - 3), jumPower: 5, drawCount: 10);
            //for(int j = 0; j < Enum.GetValues(typeof(Hurdle.hurdle)).Length; j++)
            //{
            //    hurdles.Add(new Hurdle((Hurdle.hurdle)j));
            //    Console.SetCursorPosition(0, 0);
            //    Console.Write((Hurdle.hurdle)j);
            //}
            hurdles.Add(new Hurdle(Hurdle.hurdle.cactus));
            
            Console.WindowWidth = screen.x;
            Console.WindowHeight = screen.y;
            Console.BufferWidth = screen.x;
            Console.BufferHeight = screen.y;
        }

        public void SetFram()
        {
            for (int i = 0; i < screen.y - 1; i++)
            {
                for (int j = 0; j < screen.x; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (i == 0)
                    {
                        if (j == 0)
                            Console.Write("┏");
                        else if (j == screen.x-1)
                            Console.Write("┓");
                        else
                            Console.Write("━");
                    }
                    else if (i == screen.y - 2)
                    {
                        if (j == 0)
                            Console.Write("┗");
                        else if (j == screen.x - 1)
                            Console.Write("┛");
                        else
                            Console.Write("━");
                    }
                    else
                    {
                        if (j == 0 || j == screen.x-1)
                            Console.Write("┃");
                        else
                            continue;
                    }
                }
            }
        }

        public void Draw()
        {
            Console.Clear();
            SetFram();
            UISet();
            KeyControl(); 
            
            for(int i=0;i<hurdles.Count;i++)
                hurdles[i].Draw();

            player.Draw();

            if (IsCrash())
                type = GameType.over;
        }

        void KeyControl()
        {
            if(Console.KeyAvailable)
            {
                switch (_getch())
                {
                    default:
                        player.Jump();
                        break;
                }
            }
        }

        void UISet()
        {
            int posX = screen.x - 18;
            Console.SetCursorPosition(posX, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(posX, 1);
            Console.Write("┃                ┃");
            //Console.SetCursorColor(ConsoleColor.Blue);
            Console.SetCursorPosition(posX + 2, 1);
            Console.Write("SCORE : " + score);
            //Console.SetCursorColor();
            Console.SetCursorPosition(posX, 2);
            Console.Write("┗━━━━━━━━━━━━━━━━┛");
        }

        bool IsCrash()
        {
            for(int i=0;i<player.colider.Count;i++)
            {
                Vector2 p = player.colider[i];
                for(int j=0;j<hurdles.Count;j++)
                {
                    for(int k = 0; k < hurdles[j].colider.Count;k++)
                    {
                        Vector2 c = hurdles[j].colider[k];
                        if(p.x == c.x && p.y == c.y)
                            return true;
                    }
                }
            }

            return false;
        }
    }

    class Program
    {
    //    [DllImport("kernel32.dll", SetLastError = true)]
    //    static extern bool ReadConsoleOutputCharacter(
    //    IntPtr hConsoleOutput,
    //    [Out] StringBuilder lpCharacter,
    //    uint length,
    //    COORD bufferCoord,
    //    out uint lpNumberOfCharsRead
    //);

    //    [DllImport("kernel32.dll", SetLastError = true)]
    //    static extern IntPtr GetStdHandle(int nStdHandle);

        static Game game = null;

        static void Main(string[] args)
        {
            int frame = 0;
            if (game == null)
                game = new Game(new Vector2(80, 25), 1, 50);
            game.type = Game.GameType.gaming;
            Console.CursorVisible = false;
            while(game.type == Game.GameType.gaming)
            {
                game.Draw();
                Thread.Sleep(10);
                Console.SetCursorPosition(0, 24);
                Console.Write(frame);
                frame += 1;
            }

            Console.SetCursorPosition(0, 24);
            Console.Write("Game Over : "+game.score);

            Console.CursorVisible = true;
        }

        //static public StringBuilder ReadChar(Vector2 v)
        //{
        //    try
        //    {
        //        IntPtr h = GetStdHandle(-11);
        //        if (h == IntPtr.Zero || h == new IntPtr(-1))
        //        {
        //            //Console.WriteLine("Invalid console handle.");
        //            return null;
        //        }

        //        StringBuilder sb = new StringBuilder(1);
        //        uint _i = 0;
        //        COORD coord = new COORD { X = (short)v.x, Y = (short)v.y };

        //        bool result = ReadConsoleOutputCharacter(h, sb, 1, coord, out _i);

        //        if (!result)
        //        {
        //            int errorCode = Marshal.GetLastWin32Error();
        //            //Console.WriteLine($"ReadConsoleOutputCharacter failed with error code: {errorCode}");
        //            return null;
        //        }

        //        char readChar = sb.Length > 0 ? sb[0] : '\0';

        //        if (readChar == '\0' || readChar == ' ')
        //        {
        //            //Console.WriteLine($"No character at ({coord.X}, {coord.Y}).");
        //            return null;
        //        }

        //        return sb;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.SetCursorPosition(0, 0);
        //        Console.Write(e.ToString());
        //        return null;
        //    }
        //}
    }
}
