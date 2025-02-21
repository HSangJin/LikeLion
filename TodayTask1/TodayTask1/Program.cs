using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static string name = "레온";

        const string story_bg = "오래된 전설이 전해지는 세계. 주인공이 사는 마을 근처에는 깊은 숲이 있고, 그 안에는 아무도 들어가지 않는 신비로운 유적이 존재한다. 사람들은 그곳을 \"잊힌 신전\"이라 부르며, 오래된 신들의 저주가 깃들어 있다고 믿는다.",
                title = "잊힌 신전의 비밀",
                subtitle1 = "1. 서막 - 금지된 숲",
                story1_1 = "마을의 어른들은 깊은 숲에 들어가지 말라고 경고했지만, {0}은 도저히 호기심을 참을 수 없었다. 밤이 되자 그는 손전등과 단검을 챙겨 숲으로 향했다.",
                story1_2 = "(바람이 나뭇잎을 스치는 소리. 풀숲 사이에서 이상한 빛이 새어 나온다.)",
                story1_3 = "{0} : \"이건… 뭘까? 저 안에 뭐가 있는 거지?\"",
                story1_4 = "빛을 따라 걷다 보니 거대한 석상과 함께 신전의 입구가 나타났다. 오래된 돌문에는 이상한 문자가 새겨져 있었다.",
                story1_5 = "{0} : \"전설 속의 잊힌 신전… 진짜 있었어?\"",
                story1_6 = "그때, 뒤에서 날카로운 목소리가 들렸다.",
                story1_7 = "이라: \"너, 여기서 뭐 하는 거야?\"",
                story1_8 = "깜짝 놀란 {0}이 몸을 돌리자, 후드를 깊이 눌러쓴 여인이 그를 바라보고 있었다.",

                subtitle2 = "2. 신비로운 모험가",
                story2_1 = "'이라'라는 이름의 여인은 신전을 조사하러 온 듯 보였다. 그녀는 {0}을 경계하면서도 신전에 대해 꽤 많은 것을 알고 있었다.",
                story2_2 = "이라: \"이곳은 장난삼아 들어올 만한 곳이 아니야. 네가 여기서 본 것은 잊고 돌아가.\"",
                story2_3 = "{0}: \"그럴 수 없어! 이곳이 왜 위험한데?\"",
                story2_4 = "이라가 한숨을 쉬며 벽을 가리켰다. 오래된 벽화 속에는 거대한 존재가 봉인되는 장면이 그려져 있었다.",
                story2_5 = "이라: \"옛날에 이 신의 힘을 이용하려 했던 사람들이 있었어. 하지만 그 힘은 감당할 수 없는 것이었고, 결국 이곳에 봉인당했지. 봉인을 풀면 어떤 일이 벌어질지 몰라.\"",
                story2_6 = "하지만 {0}은 그 말이 더 궁금했다. 신전의 비밀을 더 알고 싶었다.",

                subtitle3 = "3. 봉인된 힘",
                story3_1 = "{0}과 이라는 결국 신전 안으로 들어갔다. 어두운 내부에는 희미한 빛이 깜빡이며 벽을 타고 흐르고 있었다.",
                story3_2 = "{0}: \"이건 마치 살아 있는 것 같아…\"",
                story3_3 = "그 순간, 그들의 앞에 오래된 석문이 나타났다. 중앙에는 손을 대면 열릴 것 같은 원형 무늬가 새겨져 있었다.",
                story3_4 = "이라: \"이건… 봉인의 문이야.\"",
                story3_5 = "{0}: \"어쩌면, 이 안에 봉인된 신이…\"",
                story3_6 = "이라가 강하게 고개를 저었다.",
                story3_7 = "이라: \"아니, 네가 뭘 상상하든 그 이상이야. 봉인을 풀면 우리는 모두 위험해질 거야.\"",
                story3_8 = "하지만 그때, 신전 밖에서 누군가 다가오는 소리가 들렸다.",
                story3_9 = "로건: \"거기 누구냐!\"",

                subtitle4 = "4. 촌장의 경고",
                story4_1 = "마을 촌장인 로건이 무거운 걸음을 옮기며 신전 안으로 들어왔다.",
                story4_2 = "로건: \"{0}! 너한테 여기 오지 말라고 했잖아!\"",
                story4_3 = "{0}: \"촌장님은… 이곳에 대해 뭘 알고 있는 거죠?\"",
                story4_4 = "로건은 한숨을 쉬더니 신전의 벽을 쓸어보며 말했다.",
                story4_5 = "로건: \"이 봉인은 오래전, 우리 조상들이 신의 힘을 막기 위해 만든 거다. 봉인이 풀리면 마을뿐만 아니라 이 땅 전체가 위험해질 거야.\"",
                story4_6 = "이라가 로건을 노려보며 물었다.",
                story4_7 = "이라: \"그럼 당신은 이 신의 정체를 아는 건가?\"",
                story4_8 = "로건은 잠시 망설이다가 중얼거렸다.",
                story4_9 = "로건: \"신이 아니라… 재앙이다.\"",

                subtitle5 = "5. 선택의 순간",
                story5_1 = "{0}은 고민에 빠졌다. 봉인을 풀면 세상이 변할 수도 있다. 하지만 그 변화가 좋은 것인지, 나쁜 것인지 아무도 모른다.",
                story5_2 = "{0}: (속으로) \"나는 어떻게 해야 하지…?\"",
                story5_3 = "선택지:",
                story5_4 = "1. 봉인을 푼다 – 신이 깨어나며 세상이 변화하기 시작한다.",
                story5_5 = "2. 봉인을 유지한다 – 신전은 다시 어둠 속으로 사라지고, 비밀을 묻는다.",
                story5_6 = "3. 새로운 길을 찾는다 – 이라와 함께 신의 힘을 제어할 방법을 모색한다.",
                story5_7 = "\n\n",
                story5_8 = "이제 선택은 {0}에게 달려 있어. 어떤 결말로 이어질지 궁금해!",
                story5_9 = "To Be Continue..";

        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임스토리1
            //텍스트노벨만들기

            Loading();
            Wait("\t [ 아무키나 눌러 게임 시작! ]");
            Start();
        }

        static void Loading()
        {
            int index = 0;
            bool isLoop = true;
            while(isLoop)
            {
                Console.Clear();

                Console.WriteLine(" [ "+title+" ]");
                Console.WriteLine(" 로딩중..");

                Console.Write(" ");
                for (int i = 0; i < 10; i++)
                {
                    if (i < index)
                        Console.Write("■");
                    else
                        Console.Write("□");
                }
                index += 1;
                if (index > 10)
                    isLoop = false;
                Thread.Sleep(500);
            }
        }

        static void Start()
        {

            Console.Clear();
            List<string> values = new List<string>() { name, story_bg, title, subtitle1, story1_1, story1_2, story1_3, story1_4, story1_5, story1_6, story1_7, story1_8, subtitle2, story2_1, story2_2, story2_3, story2_4, story2_5, story2_6, subtitle3, story3_1, story3_2, story3_3, story3_4, story3_5, story3_6, story3_7, story3_8, story3_9, subtitle4, story4_1, story4_2, story4_3, story4_4, story4_5, story4_6, story4_7, story4_8, story4_9, subtitle5, story5_1, story5_2, story5_3, story5_4, story5_5, story5_6, story5_7, story5_8, story5_9 };
            for (int i = 0; i < values.Count; i++)
                Console.WriteLine(values[i]);
            Console.Clear();

            Intro(title, story_bg);

            Story1(subtitle1, new List<string>() { story1_1, story1_2, story1_3, story1_4, story1_5, story1_6, story1_7, story1_8 });
            Story2(subtitle2, new List<string>() { story2_1, story2_2, story2_3, story2_4, story2_5, story2_6 });
            Story3(subtitle3, new List<string>() { story3_1, story3_2, story3_3, story3_4, story3_5, story3_6, story3_7, story3_8, story3_9 });
            Story4(subtitle4, new List<string>() { story4_1, story4_2, story4_3, story4_4, story4_5, story4_6, story4_7, story4_8, story4_9 });
            Story5(subtitle5, new List<string>() { story5_1, story5_2, story5_3, story5_4, story5_5, story5_6, story5_7, story5_8, story5_9 });
        }

        static void Intro(string title, string text)
        {
            Console.Clear();
            TextAnimation(title, 3f, 0.5f);
            Console.WriteLine("\n[ 당신의 이름을 입력해주세요 ]");
            Console.Write("\t");
            name = Console.ReadLine();

            Console.Clear();
            TextAnimation(title, 3f, 1f);
            Console.WriteLine("");

            TextAnimation(text, 10f);
            Wait();
        }

        static void Story1(string title, List<string> texts)
        {
            Console.Clear();
            TextAnimation(title, 3f, 1f);

            for (int i = 0; i < texts.Count; i++)
            {
                Console.Clear();
                TextAnimation(texts[i], 1f);
                Wait();
            }
        }

        static void Story2(string title, List<string> texts)
        {
            Console.Clear();
            TextAnimation(title, 3f, 1f);

            for (int i = 0; i < texts.Count; i++)
            {
                Console.Clear();
                TextAnimation(texts[i], 1f);
                Wait();
            }
        }

        static void Story3(string title, List<string> texts)
        {
            Console.Clear();
            TextAnimation(title, 3f, 1f);

            for (int i = 0; i < texts.Count; i++)
            {
                Console.Clear();
                TextAnimation(texts[i], 1f);
                Wait();
            }
        }

        static void Story4(string title, List<string> texts)
        {
            Console.Clear();
            TextAnimation(title, 3f, 1f);

            for (int i=0;i<texts.Count;i++)
            {
                Console.Clear();
                TextAnimation(texts[i], 1f);
                Wait();
            }
        }

        static void Story5(string title, List<string> texts)
        {
            Console.Clear();
            TextAnimation(title, 3f, 1f);

            for (int i = 0; i < 2; i++)
            {
                TextAnimation(texts[i], 1f);
                Wait();
            }

            TextAnimation(texts[2], 0.25f);
            TextAnimation(texts[3], 0.5f);
            TextAnimation(texts[4], 0.5f);
            TextAnimation(texts[5], 0.5f);
            TextAnimation(texts[6]);
            TextAnimation(texts[7], 2f);

            Console.WriteLine("\n[ 선택지를 골라주세요 ]");
            Console.ReadLine();

            Console.Clear();
            TextAnimation("......", 5f);

            Console.Clear();
            TextAnimation(texts[8], 1.5f);
            Wait();
        }

        static void TextAnimation(string text, float time = 0f, float endDelay = 0f)
        {
            int delay = (int) (Math.Round(time * 1000f) / (float)text.Length);

            if (text.Contains("{0}"))
                text = string.Format(text, name);

            for (int i=0;i<text.Length;i++)
            {
                Console.Write(text.Substring(i, 1));
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            delay = (int)Math.Round(endDelay * 1000f);
            Thread.Sleep(delay);
        }

        static void Wait(string text = "[ 아무키나 눌러 계속! ]")
        {
            text = "\n" + text;
            Console.WriteLine(text);
            Console.Write("\t");
            Console.ReadLine();
        }
    }
}
