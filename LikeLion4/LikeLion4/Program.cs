using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting; //문자열 변수를 선언
            //greeting = "Hello, World!"; //변수가 앖을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력 : Hello , World!


            ////변수 선언과 초기화를 한번에 수행
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; //실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            ////변수 출력
            //Console.WriteLine(score); //출력 100
            //Console.WriteLine(temperature); //출력 36.5
            //Console.WriteLine(city); //출력 : Seoul


            ////같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            //int x = 10, y = 20, z = 30; //정수형 변수 x,y,z 를 선언하고 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            //const double Pi = 3.141592; //상수 pi선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi : " + Pi); //출력 : Pi: 3.141592
            //Console.WriteLine("Max Score : " + MaxScore); //출력 : Max Score:100


            int att = 16755;
            int maxHP = 78103;

            int cri = 36;
            int special = 1017;
            int subdue = 41;
            int swiftness = 611;
            int patience = 22;
            int skill = 39;

            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 :" + att);
            Console.WriteLine("최대 생명력 : " + maxHP);

            Console.WriteLine("전투 특성");
            Console.WriteLine("치명 : " + cri);
            Console.WriteLine("특화 : " + special);
            Console.WriteLine("제압 : " + subdue);
            Console.WriteLine("신속 : " + swiftness);
            Console.WriteLine("인내 : " + patience);
            Console.WriteLine("숙련 : " + skill);

            Console.WriteLine("\n\n");

            Print(new List<string>() { "기본특성", "공격력 : "+att, "최대 생명력 : "+maxHP, "전투 특성", "치명 : "+cri, "특화 : "+special, "제압 : "+subdue, "신속 : "+swiftness, "인내 : "+patience, "숙련 : "+skill });
        }

        void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void Print(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);
        }
    }
}
