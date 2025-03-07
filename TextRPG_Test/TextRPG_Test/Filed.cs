using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Filed
    {
        Game game;
        Player player;
        Monster monster;
        int filedNum = default;

        public Filed(Game game, Player player, int num = 0)
        {
            this.game = game;
            this.player = player;
            this.filedNum = num;
        }

        public void SelectFiled()
        {
            bool isLoop = true;
            while (isLoop)
            {
                Console.WriteLine("==== 던전 선택 ====");
                Console.WriteLine("1. 초급던전");
                Console.WriteLine("2. 중급던전");
                Console.WriteLine("3. 고급던전");
                Console.WriteLine("4. 돌아가기");

                try
                {
                    switch(int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            filedNum = 1;
                            CreateMonster();
                            isLoop = false;
                            break;
                        case 2:
                            filedNum = 2;
                            CreateMonster();
                            isLoop = false;
                            break;
                        case 3:
                            filedNum = 3;
                            CreateMonster();
                            isLoop = false;
                            break;
                        case 4:
                            filedNum = -1;
                            isLoop = false;
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine("숫자를 입력해주세요"); }
                Thread.Sleep(500);
            }
        }

        public void CreateMonster()
        {
            switch(filedNum)
            {
                case 1:
                    monster = new Monster("초급몬스터", 30, 10, 10);
                    break;
                case 2:
                    monster = new Monster("중급몬스터", 50, 15, 20);
                    break;
                case 3:
                    monster = new Monster("고급몬스터", 70, 20, 30);
                    break;
            }
        }

        public void Render()
        {
            while(filedNum >= 0)
            {
                Console.Clear();
                switch(filedNum)
                {
                    case 0:
                        SelectFiled();
                        break;
                    default:
                        Battle();
                        break;
                }
            }
        }

        public void Battle()
        {
            if (monster == null)
                return;

            bool isLoop = true;
            while (isLoop)
            {
                if (player.IsDead() == true)
                {
                    player = null;
                    isLoop = false;
                    break;
                }

                Console.Clear();
                monster.Render();
                player.Render();
                Console.WriteLine("==== 행동 선택 ===");
                Console.WriteLine("1. 공격");
                Console.WriteLine("2. 도망");
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            //플레이어 부터 공격
                            monster.OnDamaged(player.GetAttack());

                            //몬스터 죽음
                            if (monster.IsDead() == false)
                            {
                                player.OnDamaged(monster.GetAttack());
                            }
                            else
                            {
                                isLoop = false;
                                filedNum = 0;
                                game.AddScore(monster.GetScore());
                                monster = null;
                            }

                            //플레이어 죽음
                            if (player.IsDead() == true)
                            {
                                player = null;
                                isLoop = false;
                            }   
                            break;
                        case 2:
                            monster = null;
                            isLoop = false;
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine("숫자를 입력해주세요"); }
                Thread.Sleep(500);
            }
        }
    }
}
