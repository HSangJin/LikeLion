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

        const string end1_subtitle = "(엔딩: \"신의 귀환\" - 파멸 루트)", end1_selectText = "1. 봉인을 푼다 – \"신의 귀환\" 엔딩";
        static List<string> end1_dialogs = new List<string>() {
                "{0}은 망설였지만, 결국 손을 봉인의 중심에 올려놓았다.",
                "{0}: \"나는 진실을 보고 싶어.\"",
                "이라와 로건이 동시에 외쳤다.",
                "이라: \"안 돼! 멈춰!\"",
                "로건: \"멍청한 짓이다!\"",
                "하지만 이미 늦었다. {0}이 손을 대자 신전 전체가 흔들리기 시작했다. 벽에 새겨진 문양들이 빛나더니, 거대한 문이 천천히 열렸다. 그 안에서 검은 안개가 뿜어져 나왔다.",
                "그리고, 그 안개 속에서 거대한 실루엣이 서서히 모습을 드러냈다.",
                "???: \"드디어… 자유다.\"",
                "그것은 인간이 이해할 수 없는 형태의 존재였다. 거대한 뿔, 타오르는 눈동자, 땅을 울리는 목소리.",
                "{0}: (숨을 삼키며) \"이게… 신이야?\"",
                "그러나 그것은 구원이 아니라 파멸이었다. 신의 힘이 해방되면서 마을과 주변 땅이 변화하기 시작했다. 숲은 검게 물들고, 하늘은 붉게 변했다.",
                "이라와 로건은 {0}을 붙잡고 도망치려 했지만, 신은 손을 휘둘러 그들을 압도했다.",
                "???: \"이제 나는 이 땅을 다시 지배할 것이다.\"",
                "{0}은 자신의 선택이 무엇을 의미하는지 깨달았지만, 되돌릴 방법은 없었다. 신전은 무너지고, 새로운 어둠이 세상을 덮기 시작했다…"};

        const string end2_subtitle = "(엔딩: \"잊힌 비밀\" - 평온 루트)", end2_selectText = "2. 봉인을 유지한다 – \"잊힌 비밀\" 엔딩";
        static List<string> end2_dialogs = new List<string>() {
                "{0}은 봉인된 문 앞에서 주먹을 꽉 쥐었다.",
                "{0}: \"아니… 이 힘은 위험해. 우리는 감당할 수 없어.\"",
                "이라가 안도의 한숨을 쉬며 고개를 끄덕였다.",
                "이라: \"잘 생각했어.\"",
                "하지만 로건은 여전히 긴장한 표정이었다.",
                "로건: \"하지만 네가 이미 이곳을 알아버린 이상, 이곳은 다시 봉인해야 해. 절대 누구도 이곳에 들어올 수 없게.\"",
                "{0}과 이라는 힘을 합쳐 신전 입구를 다시 봉인하기 시작했다. 거대한 돌문이 천천히 닫히고, 봉인의 빛이 다시 차단되었다.",
                "{0}: \"이제… 정말 끝난 걸까?\"",
                "이라: \"완전히 끝난 건 아니야. 하지만 적어도 우리가 이 힘을 잘못 사용하지 않도록 막을 수는 있겠지.\"",
                "로건은 조용히 고개를 끄덕였다.",
                "로건: \"네가 올바른 선택을 했길 바란다, {0}.\"",
                "그들은 신전을 빠져나와 다시 숲으로 돌아갔다. 봉인은 다시 어둠 속에 묻혔고, 이 비밀을 아는 사람은 이제 세 명뿐이었다.",
                "그리고 세월이 흐르면, 다시 이곳을 찾으려는 또 다른 누군가가 나타날지도 모른다."};

        const string end3_subtitle = "(엔딩: \"인간의 선택\" - 희망 루트)", end3_selectText = "3. 새로운 길을 찾는다 – \"인간의 선택\" 엔딩";
        static List<string> end3_dialogs = new List<string>() {
                "{0}은 봉인을 풀지 않고, 하지만 그대로 두지도 않았다.",
                "{0}: \"이 힘을 그냥 두는 것만이 답이 아닐 수도 있어.\"",
                "이라가 놀란 눈으로 그를 바라봤다.",
                "이라: \"뭐?\"",
                "{0}: \"우리가 이 힘을 제어하는 방법을 찾으면 어떨까? 신의 힘을 단순히 봉인하거나 해방하는 게 아니라, 인간이 다룰 수 있도록 연구하는 거야.\"",
                "로건이 난색을 보이며 말했다.",
                "로건: \"위험한 생각이야. 힘은 쉽게 타락할 수 있다.\"",
                "{0}: \"하지만 만약 우리가 제대로 이해하고 사용한다면? 이 힘이 재앙이 아니라, 새로운 희망이 될 수도 있지 않을까요?\"",
                "이라는 잠시 생각에 잠겼다가 결심한 듯 말했다.",
                "이라: \"…그래. 어쩌면 우리가 신의 힘을 어떻게 다뤄야 하는지, 새로운 길을 찾을 수도 있겠지.\"",
                "로건은 걱정스러운 표정을 지었지만, 결국 고개를 끄덕였다.",
                "로건: \"하지만 반드시 신중해야 한다. 작은 실수 하나로 모든 걸 잃을 수도 있어.\"",
                "그들은 함께 연구하기로 결심했다. 신전을 단순히 봉인하는 것이 아니라, 그 안에 깃든 힘을 분석하고, 이해하는 것.",
                "그것이 인류가 재앙을 막고, 신의 힘을 새로운 희망으로 바꾸는 길이 될 수도 있었다."};

        const string end4_subtitle = "(엔딩: \"망설임의 대가\" - 최악 루트)", end4_selectText = "4. 아무것도 하지 않는다 – \"망설임의 대가\" 엔딩";
        static List<string> end4_dialogs = new List<string>()
        {
            "레온은 문 앞에서 두 손을 떨며 고민했다.",
            "레온: (속으로) 무엇이 옳은 걸까? 봉인을 풀어야 하나? 아니면… 그냥 두는 게 맞을까?",
            "이라와 로건이 재촉했다.",
            "이라: \"레온, 빨리 결정해! 시간이 없어!\"",
            "로건: \"주저하면 안 된다! 이 힘을 깨우면 안 돼!\"",
            "하지만 레온은 너무 많은 생각에 사로잡혀 한 발자국도 움직이지 못했다.",
            "그때였다.",
            "신전이 갑자기 크게 흔들렸다. 어디선가 금이 가는 소리가 들리더니, 봉인의 문이 스스로 빛을 내며 진동하기 시작했다.",
            "이라: \"뭐야…? 이건 우리가 건드리지도 않았는데!\"",
            "로건: (충격) \"설마… 봉인이 약해진 건가?\"",
            "레온이 망설이는 사이, 오래된 봉인은 점점 무너지고 있었다.",
            "레온: \"아니, 잠깐! 나는 아직 선택하지 않았어!\"",
            "하지만 이미 늦었다. 봉인은 인간의 의지가 개입하지 않으면 결국 자연적으로 붕괴될 수밖에 없었다. 그것은 오랜 세월에 걸쳐 결정된 일이었다.",
            "거대한 균열이 퍼지더니, 마침내 봉인이 산산조각 났다.",
            "그 안에서 검은 안개가 뿜어져 나오며, 어둠의 신이 깨어났다.",
            "???: \"드디어… 자유로워졌다.\"",
            "이라와 로건은 경악하며 뒤로 물러났다.",
            "이라: \"레온… 네가 결정을 내리지 않아서, 스스로 깨어난 거야!\"",
            "로건: \"이 바보 같은 녀석! 너의 망설임이 이 땅을 멸망시켰다!\"",
            "레온은 뒤늦게 손을 뻗었지만, 이제 아무 의미가 없었다.",
            "신의 붉은 눈이 레온을 내려다보았다.",
            "???: \"네가 나를 깨웠구나. 보상으로… 너부터 없애주지.\"",
            "신의 손짓 하나에 신전이 무너지고, 세상은 어둠 속으로 빠져들었다.",
            "레온의 마지막 생각은 단 하나였다.",
            "나는… 선택을 했어야 했어.\""
        };

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
            //Console.Clear();
            //List<string> values = new List<string>() { name, story_bg, title, subtitle1, story1_1, story1_2, story1_3, story1_4, story1_5, story1_6, story1_7, story1_8, subtitle2, story2_1, story2_2, story2_3, story2_4, story2_5, story2_6, subtitle3, story3_1, story3_2, story3_3, story3_4, story3_5, story3_6, story3_7, story3_8, story3_9, subtitle4, story4_1, story4_2, story4_3, story4_4, story4_5, story4_6, story4_7, story4_8, story4_9, subtitle5, story5_1, story5_2, story5_3, story5_4, story5_5, story5_6, story5_7, story5_8, story5_9 };
            //for (int i = 0; i < values.Count; i++)
            //    Console.WriteLine(values[i]);
            Console.Clear();

            Intro(title, story_bg);

            Story1(subtitle1, new List<string>() { story1_1, story1_2, story1_3, story1_4, story1_5, story1_6, story1_7, story1_8 });

            Story2(subtitle2, new List<string>() { story2_1, story2_2, story2_3, story2_4, story2_5, story2_6 });

            Story3(subtitle3, new List<string>() { story3_1, story3_2, story3_3, story3_4, story3_5, story3_6, story3_7, story3_8, story3_9 });

            Story4(subtitle4, new List<string>() { story4_1, story4_2, story4_3, story4_4, story4_5, story4_6, story4_7, story4_8, story4_9 });

            string input = Story5(subtitle5, new List<string>() { story5_1, story5_2, story5_3, story5_4, story5_5, story5_6, story5_7, story5_8, story5_9 });

            switch (input)
            {
                case "1":
                    EndTextAction(title:story5_4, subtitle:end1_subtitle, dialogs:end1_dialogs, selectText:end1_selectText);
                    break;
                case "2":
                    EndTextAction(title: story5_5, subtitle: end2_subtitle, dialogs: end2_dialogs, selectText: end2_selectText);
                    break;
                case "3":
                    EndTextAction(title: story5_6, subtitle: end3_subtitle, dialogs: end3_dialogs, selectText: end3_selectText);
                    break;
                default:
                    EndTextAction(end4_subtitle, end4_dialogs, end4_selectText);
                    break;
            }
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

        static string Story5(string title, List<string> texts)
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
            string input = Console.ReadLine();

            Console.Clear();
            TextAnimation("......", 5f);

            return input;

            //Console.Clear();
            //TextAnimation(texts[8], 1.5f);
            //Wait();
        }

        static void EndTextAction(string subtitle, List<string> dialogs, string selectText, string title = "")
        {
            for (int i = 0; i < dialogs.Count; i++)
            {
                Console.Clear();
                if(i==0 && !string.IsNullOrEmpty(title))
                    Console.WriteLine(title + "\n");
                TextAnimation(dialogs[i], 0.5f);
                Wait();
            }

            Console.Clear();
            TextAnimation(subtitle, 1.5f);
            Console.WriteLine("\n"+selectText);
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
            string input = Console.ReadLine();
            //if (input == "99")
            //    return;
        }
    }
}
