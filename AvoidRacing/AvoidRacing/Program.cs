using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidRacing
{
    public struct Vector2
    {
        int x, y;
        public Vector2(int x=0, int y=0)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Player
    {
        string[] player =
        {
            "       _________",
            "      /         \\",
            "  ___|___________|___",
            " |o  _   _   _   _  o|",
            " '-(_)-' '-' '-' (_)-'"
        };
        public Vector2 pos;
    }

    public class  Other
    {
        string[] other1 =
        {
            "       _______",
            "      /       \\",
            " ___|_________|___,",
                "| o  _   _   _  o |",
                " '-(_)-'---'(_)-'"
        };
        string[] other2 =
        {
            "       _______",
            "      /       \\",
            " ___|_________|___",
            "|  _  _  _   |   |",
            " '-(_)-(_)-(_)-'---'"
        };
        string[] other3 =
        {
            "       _______",
            "      /|_||_\\`.__",
            "     (   _    _ _\\",
            "  ===`-(_)--(_)-'===="
        };
        string[] other4 =
        {
            "       _______",
            "      /       \\",
            " ___|_________|___",
            "| o   _   _   _   o|",
            " '-(_)-' '-' (_)-'"
        };
        string[] other5 =
        {
            "       _______",
            "      /       \\",
            " ___|_________|___",
            "| _   _   _   _  |",
            " '-(_)-(_)-(_)-(_)-'"
        };
        
        public enum Car { other1, other2, other3, other4, other5 };
        public Car name { get; private set; }

        public Other(Car name)
        {
            this.name = name;
        }

        public void Move()
        {

        }

        public void Draw()
        {

        }
    }

    public class Hurdles
    {
        string[] hurdles1 =
        {
            "     _____",
            "    | STOP |",
            "  ----|-----  ",
            "     |"
        };
        string[] hurdles2 =
        {
            "     _______",
            "    | ROAD  |",
            "    | WORK  |",
            "  ----|------  ",
            "     |"
        };
        string[] hurdles3 =
        {
            "   ______",
            "  /      \\",
            " /        \\",
            " \\________/"
        };
        public enum  hurdles { hurdles1, hurdles2, hurdles3 };
        public hurdles name { get; private set; }

        public Hurdles(hurdles name)
        {
            this.name = name;
        }

        public void Spawn()
        {
            Init();
        }

        void Init(int line = -1)
        {
            if(line < 0 || line > 4)
            {
                Random rand = new Random();
                line = rand.Next(0, 5);
            }
        }

        public void Move()
        {

        }

        public void Draw()
        {

        }
    }

    public class  Level
    {
        int heightOfLoad = 5;
        int loadCount = 5;
        string boundaryLine = "━━━━━━━━        ";
        Vector2 boundaryPos = new Vector2();

        public void DrawLevel()
        {

        }

        public void DrawBoundary()
        {

        }
    }

    public class  Game
    {
        // 차선은 총 5개
        // 맞은편에서 차가 오고있고(좌우로 움직임:랜덤)
        // 방해물은 움직이지 않음

        public static Game instance;

        public enum GameState { Start, Loading, GameOver };
        public GameState state { get; private set; }

        Level level;
        Player player;
        Other[] other;

        public Game()
        {
            instance = this;
        }

        public void Start()
        {

        }

        public void Loading()
        {

        }

        public void GameOver()
        {
            level = new Level();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
