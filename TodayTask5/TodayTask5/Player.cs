using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask5
{
    class Player
    {
        public Info info;
        public void SetDamage(int damage) { info.hp -= damage; }
        public void Draw()
        {
            Console.WriteLine("===== 플레이어 정보 =====");
            Console.WriteLine("캐릭터 직업 : " + info.name);
            Console.WriteLine($"공력력 : {info.attack}, 체력 : {info.hp}, 방어력 : {info.defense}");
        }

        public void SelectJob()
        {
            info = new Info();
            Console.WriteLine("직업을 선택하세요(1.기사 2. 마법사 3.도둑");
            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());
            switch (iInput)
            {
                case 1:
                    info.name = "기사";
                    info.hp = 100;
                    info.attack = 10;
                    break;
                case 2:
                    info.name = "마법사";
                    info.hp = 90;
                    info.attack = 15;
                    break;
                case 3:
                    info.name = "도둑";
                    info.hp = 85;
                    info.attack = 13;
                    break;
            }
        }

        ~Player()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine("캐릭터가 사망했습니다.");
            Environment.Exit(0);
        }
    }
}
