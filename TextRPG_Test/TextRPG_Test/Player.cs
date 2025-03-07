using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public struct PlayerData
    {
        public string name;
        public int hp;
        public int attack;
        public int gold;
    }

    public class Player
    {
        PlayerData data;

        public void Initialization(string name, int hp, int attack)
        {
            data = new PlayerData();
            data.name = name;
            data.hp = hp;
            data.attack = attack;
        }

        public void SelectJob()
        {
            bool isLoop = true;
            while (isLoop)
            {
                Console.WriteLine("==== 직업선택 ====");
                Console.WriteLine("1. 전사 : 체력[100] 공격력[10]");
                Console.WriteLine("2. 마법사 : 체력[80] 공격력[20]");
                Console.WriteLine("3. 도적 : 체력[70] 공격력[15]");
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Initialization("전사", 100, 10);
                            isLoop = false;
                            break;
                        case 2:
                            Initialization("마법사", 80, 20);
                            isLoop = false;
                            break;
                        case 3:
                            Initialization("도적", 70, 15);
                            isLoop = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e) { Console.WriteLine("숫자를 입력해주세요"); }
                Thread.Sleep(500);
            }
        }

        public void OnDamaged(int damage) { data.hp -= damage; }
        public int GetAttack()
        {
            Random rand = new Random();
            int r = rand.Next(0, 2);
            switch(r)
            {
                case 0:
                    return data.attack * 2;
                default:
                    return data.attack;
            }
        }

        public bool IsDead() { return data.hp <= 0; }

        public void Render()
        {
            Console.WriteLine("==== 플레이어 정보 ====");
            Console.WriteLine("직업 : "+data.name);
            Console.WriteLine($"체력 : {data.hp}, 공격력 : {data.attack}");
        }

        ~Player()
        {
            Console.WriteLine("GameOver");
            Console.WriteLine("플레이어가 사망하였습니다");
        }
    }
}
