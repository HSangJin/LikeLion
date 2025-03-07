using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask5
{
    public struct Info
    {
        public string name;
        public int hp;
        public int attack;
        public int defense;

        public Info(string name = "Unknown", int hp = 0, int attack = 0, int defense = 0)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
        }
    }
}
