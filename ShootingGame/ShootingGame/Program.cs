using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    public struct Vector2
    {
        public int x, y;

        public Vector2(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(int offset = 0)
        {
            this.x = offset;
            this.y = offset;
        }
    }

    public class Bullet
    {
        string bullet = "->";
        public Vector2 pos;
        public bool fire = false;

        public void Draw(int x = 0, int y = 0)
        {
            if (fire)
            {
                Program.SetCursorColor(ConsoleColor.Cyan);

                //중간위치 보정 x -1
                Program.SetCursorPosition(x, y);
                Console.Write(bullet);

                x++;
                if (x >= Console.WindowWidth)
                {
                    fire = false;
                }
                Program.SetCursorColor();
            }
            
        }

        public void Move(Vector2 pos = new Vector2(), int offsetY = 0)
        {
            this.pos.x = pos.x + 5;
            this.pos.y = pos.y + offsetY;
        }

        public void AddX(int offsetX = 1)
        {
            pos.x += offsetX;
            if(pos.x >= Console.WindowWidth)
            {
                fire = false;
            }
        }
    }

    public class Player
    {
        string[] player = new string[]
            {
                "▶>  ",
                "▶▶>",
                "▶>  "
            };

        static public int bulletCount { get; } = 20;
        public Vector2 pos;
        public Bullet[] bullet = new Bullet[bulletCount];
        public Bullet[] bullet2 = new Bullet[bulletCount];
        public Bullet[] bullet3 = new Bullet[bulletCount];
        public Item item = new Item();
        public int itemCount = 0;

        public Player()
        {
            //플레이어 좌표 위치 초기화
            pos.x = 0;
            pos.y = Console.WindowHeight/2;
            for (int i = 0; i < bulletCount; i++)
            {
                bullet[i] = new Bullet();
                bullet2[i] = new Bullet();
                bullet3[i] = new Bullet();
            }
        }

        /// <summary> 플레이어를 그려주는 함수 </summary>
        public void Draw()
        {
            Program.SetCursorColor();
            for (int i = 0; i < player.Length; i++)
            {
                //콘솔 좌표 설정
                Program.SetCursorPosition(this.pos.x, this.pos.y + i);
                Console.Write(player[i]);
            }
        }

        public void BulletDraw()
        {
            BulletDraw(bullet);
            BulletDraw(bullet2);
            BulletDraw(bullet3);
        }

        void BulletDraw(Bullet[] bullets)
        {
            Program.SetCursorColor(ConsoleColor.Cyan);
            for (int i = 0; i < bullets.Length; i++)
            {
                bullet[i].Draw(bullet[i].pos.x - 1, bullet[i].pos.y);
                bullet[i].AddX();
            }
            Program.SetCursorColor();
        }
    }

    public class Enemy
    {
        public Vector2 pos;
        string enemy = "<-9->";

        public void Move()
        {
            pos.x--; //왼쪽으로 움직임 

            if(pos.x < 1)
                Reset();
        }

        /// <summary> 적 그리기 </summary>
        public void Draw()
        {
            Program.SetCursorColor(ConsoleColor.Red);
            Program.SetCursorPosition(pos);
            Console.Write(enemy);
            Program.SetCursorColor();
        }

        public void Reset()
        {
            Random rand = new Random(); //랜덤
            pos.x = Console.WindowWidth - 3;
            pos.y = rand.Next(2, 22);
        }
    }

    public class Game
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴
        
        private Player player;
        private Enemy enemy;
        private Item item;
        public bool isGameOver = false;
        public int score = 100;

        public Game(Player player, Enemy enemy, Item item)
        {
            this.player = player;
            this.enemy = enemy;
            this.item = item;
        }

        public void Start()
        {
            //키를 입력하는 부분
            KeyControl();

            //플레이어를 그려준다
            player.Draw();

            //UI점수
            UIScore();

            //아이템 그리기
            if(item.isLife)
            {
                item.Draw();
                if (player.pos.y + 1 == item.pos.y 
                    && player.pos.x >= item.pos.x - 2 
                    && player.pos.x <= item.pos.x + 2)
                    item.Crash(player, enemy.pos);
            }

            //총알을 그려준다
            player.BulletDraw();

            enemy.Move(); //적 이동
            enemy.Draw(); //적그리기

            ClashEnemyAndBullet();
            Debug(player.itemCount);
        }

        public void Debug(object value)
        {
            Program.SetCursorPosition(0);
            Console.Write(value);
        }

        /// <summary> 키 입력 받기 </summary>
        public void KeyControl()
        {
            int pressKey;   //정수형 변수선언 키값 받을예정
            
            if(Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽

                switch (pressKey)
                {
                    case 72:    //위
                        player.pos.y--;
                        if (player.pos.y < 0)
                            player.pos.y = 0;
                        break;

                    case 80:    //아래
                        player.pos.y++;
                        if (player.pos.y > Console.WindowHeight - 3)
                            player.pos.y = Console.WindowHeight - 3;
                        break;

                    case 75:    //왼쪽
                        player.pos.x--;
                        if (player.pos.x < 1)
                            player.pos.x = 1;
                        break;

                    case 77:    //오른쪽
                        player.pos.x++;
                        if (player.pos.x > Console.WindowWidth - 3)
                            player.pos.x = Console.WindowWidth - 3;
                        break;

                    case 32: //스페이스바
                        for (int i = 0; i < player.bullet.Length; i++)
                        {
                            if (!player.bullet[i].fire)
                            {
                                player.bullet[i].fire = true;
                                player.bullet[i].Move(player.pos, 1);
                                Debug("shoot 1 : " + i);
                                break;
                            }
                        }

                        if (player.itemCount > 0)
                        {
                            for (int i = 0; i < player.bullet2.Length; i++)
                            {
                                if (!player.bullet2[i].fire)
                                {
                                    player.bullet2[i].fire = true;
                                    player.bullet2[i].Move(player.pos);
                                    Debug("shoot 2 : " + i);
                                    break;
                                }
                                
                            }
                        }

                        if(player.itemCount > 1)
                        {
                            for (int i = 0; i < player.bullet3.Length; i++)
                            {
                                if (!player.bullet3[i].fire)
                                {
                                    player.bullet3[i].fire = true;
                                    player.bullet3[i].Move(player.pos, 2);
                                    Debug("shoot 3 : " + i);
                                    break;
                                }
                            }
                        }
                        
                        break;
                }
            }
        }

        /// <summary> 점수 표시 </summary>
        public void UIScore()
        {
            int posX = Console.WindowWidth - 18;
            Program.SetCursorPosition(posX, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━┓");
            Program .SetCursorPosition(posX, 1);
            Console.Write("┃                ┃");
            Program.SetCursorColor(ConsoleColor.Blue);
            Program.SetCursorPosition(posX+2, 1);
            Console.Write("SCORE : "+score);
            Program.SetCursorColor();
            Program.SetCursorPosition(posX, 2);
            Console.Write("┗━━━━━━━━━━━━━━━━┛");
        }

        /// <summary> 적 충돌 처리 </summary>
        public void ClashEnemyAndBullet()
        {
            for (int i = 0; i < Player.bulletCount; i++)
            {
                if (IsClashEnemy(player.bullet[i], enemy.pos))
                {
                    ClashEnemyAction(player.bullet[i], i);
                }

                if (IsClashEnemy(player.bullet2[i], enemy.pos))
                {
                    ClashEnemyAction(player.bullet2[i], i);
                }

                if (IsClashEnemy(player.bullet3[i], enemy.pos))
                {
                    ClashEnemyAction(player.bullet3[i], i);
                }
            }
        }

        /// <summary> 적 충돌 감지 </summary>
        /// <param name="bullet"> 총알 </param>
        /// <param name="enemy_pos"> 적 위치 </param>
        public bool IsClashEnemy(Bullet bullet, Vector2 enemy_pos)
        {
            return bullet.fire && bullet.pos.y == enemy_pos.y && bullet.pos.x >= enemy_pos.x && bullet.pos.x <= enemy_pos.x + 5;
        }

        public void ClashEnemyAction(Bullet bullet, int index)
        {
            if (!item.isLife)
                item.Reset(enemy.pos);

            enemy.Reset();

            bullet.fire = false;
            score += 100;
        }

    }

    public class Item
    {
        public string item = "★";
        public Vector2 pos;
        public bool isLife = false;

        public void Draw()
        {
            Program.SetCursorColor(ConsoleColor.Yellow);
            Program.SetCursorPosition(pos.x, pos.y);
            Console.Write(item);
            Program.SetCursorColor();
        }

        public void Reset(Vector2 pos)
        {
            isLife = true;
            this.pos.x = pos.x;
            this.pos.y = pos.y;
        }

        /// <summary> 아이템 충돌이 일어나면 양쪽미사일 발사 </summary>
        public void Crash(Player player, Vector2 pos)
        {
            isLife = false;
            this.pos.x = pos.x;
            this.pos.y = pos.y;

            player.itemCount++;
        }
    }

    class Program
    {
        static int windowWidth = 80;
        static int windowHeight = 25;
        static int fram = 50;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.SetBufferSize(windowWidth, windowHeight);

            //플레이어 생성
            Player player = new Player();
            //적 생성
            Enemy enemy = new Enemy();
            //아이템 생성
            Item item = new Item();

            //게임 생성
            Game game = new Game(player, enemy, item);

            //유니티처럼 속도 프레임
            int dwTime = Environment.TickCount;     // 1/1000 초가 흐른다.

            while (true)
            {
                if(dwTime + fram < Environment.TickCount)
                {
                    //현재 시간 셋팅
                    dwTime = Environment.TickCount;
                    Console.Clear();
                    game.Start();
                    dwTime = Environment.TickCount;
                }
            }
        }

        static public void SetCursorColor(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
        }

        static public void SetCursorPosition(Vector2 pos = new Vector2())
        {
            SetCursorPosition(pos.x, pos.y);
        }

        static public void SetCursorPosition(int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
