using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    class Program
    {
        static Game game;
        static void Main(string[] args)
        {
            game = new Game();
            game.Render();
        }
    }
}
