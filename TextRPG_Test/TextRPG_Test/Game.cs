using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Game
    {
        Player player;
        Filed filed;
        int score;

        
        public Game()
        {
            if(player == null)
                player = new Player();
        }

        public void SelectGame()
        {
            bool isLoop = true;
            while (isLoop)
            {
                if (player.IsDead())
                    return;
                Console.Clear();
                Console.WriteLine("==== 게임선택 ====");
                Console.WriteLine("1. 전투");
                Console.WriteLine("2. 휴식");
                Console.WriteLine("3. 뽑기");

                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1: //전투
                            filed = new Filed(this, player);
                            filed.Render();
                            break;
                        case 2:
                            //휴식
                            break;
                        case 3:
                            //장비뽑기
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine("숫자를 입력해주세요"); }
                Thread.Sleep(500);
            }
        }

        public void Render()
        {
            player.SelectJob();
            while (player != null)
            {
                if (player.IsDead() == false)
                    SelectGame();
                else
                    player = null;
            }
            Console.WriteLine("점수 : " + score);
        }

        public void AddScore(int add) { score += add; }
    }
}
