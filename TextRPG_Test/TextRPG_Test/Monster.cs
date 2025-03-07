using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public struct MonsterData
    {
        public string name;
        public int hp;
        public int attack;
        public int score;
    }

    public class Monster
    {
        MonsterData data;
        public Monster(string name, int hp, int attack, int score = 0)
        {
            data = new MonsterData();
            data.name = name;
            data.hp = hp;
            data.attack = attack;
            data.score = score;
        }

        public void OnDamaged(int damage) { data.hp -= damage; }
        public int GetAttack() { return data.attack; }
        public int GetScore() { return data.score; }

        public bool IsDead() { return data.hp <= 0; }

        public void Render()
        {
            Console.WriteLine("==== 몬스터 정보 ====");
            Console.WriteLine("이름 : " + data.name);
            Console.WriteLine($"체력 : {data.hp}, 공격력 : {data.attack}");
        }
    }
}
