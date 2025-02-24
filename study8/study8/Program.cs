using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            ////두 값을 비교하여 관계를 평가한다.
            //// == 같다 != 같지않다 a < b  c < d   <=  =>
            //int x = 5, y = 10;

            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  // true


            ////논리 연산자
            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a && b);
            //// AND :    1 : 1   t
            ////          1 : 0   f
            ////          0 : 1   f
            ////          0 : 0   f
            //Console.WriteLine(a || b);
            //// OR :     1 : 1   t
            ////          1 : 0   t
            ////          0 : 1   t
            ////          0 : 0   f
            //// NOT
            //// !a
            //Console.WriteLine(!a); //false


            //int x = 5; // 0101
            //int y = 3; // 0011
            //Console.WriteLine(x & y); //AND : 1 (0001)
            //Console.WriteLine(x | y); //OR : 7 (0111)
            //Console.WriteLine(x ^ y); //XOR : 6 (0110)
            //Console.WriteLine(~x);    //NOT : -6


            //int value = 4; //0100
            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽이동 : 2 (0010)


            //int a = 10, b = 20;
            //int max;
            //max = (a > b) ? a : b; //삼항 연산자
            //Console.WriteLine(max);
            //// (비교) ? 참 : 거짓;


            //int key = 1;
            //string str = (key == 1) ? "문이 열렸습니다." : "문열기에 실패했습니다.";
            //Console.WriteLine(str);


            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            //Console.WriteLine(result);
            //int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저계산
            //Console.WriteLine(adjustedResult);


            //int score = 95;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D 학점");
            //}
            //else if (score >= 50)
            //{
            //    Console.WriteLine("E 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}


            //1단계
            //가지고 있는 소지금을 입력하세요 : 
            //0~100     무한의 대검 +1
            //101~200   카나타 +2
            //201~300   진은검 +3
            //301~400   집판검 +4
            //401~500   엑스칼리버 +5
            //501~600   유령검 +6

            //2단계
            //캐릭터 이름
            //공격력 : 100 + 1

            Console.Write("가지고 있는 소지금을 입력하세요 : ");
            string input = Console.ReadLine();
            int gold = default;
            string sword = default;
            try { gold = int.Parse(input); }
            catch(Exception e)
            {
                Console.WriteLine("소지금 파스 에러");
                Console.WriteLine(e.Message);
                return;
            }
            if (gold <= 100)
            {
                Console.WriteLine("무한의대검 구매!");
                gold -= 100;
                sword = "무한의대검";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            else if (gold <= 200)
            {
                Console.WriteLine("카타나 구매!");
                gold -= 200;
                sword = "카타나";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            else if (gold <= 300)
            {
                Console.WriteLine("진은검 구매!");
                gold -= 300;
                sword = "진은검";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            else if (gold <= 400)
            {
                Console.WriteLine("집판검 구매!");
                gold -= 400;
                sword = "집판검";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            else if (gold <= 500)
            {
                Console.WriteLine("엑스칼리버 구매!");
                gold -= 500;
                sword = "엑스칼리버";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            else if (gold <= 600)
            {
                Console.WriteLine("유령검 구매!");
                gold -= 600;
                sword = "유령검";
                Console.WriteLine("남은 소지금 : " + gold);
            } 
            else
            {
                Console.WriteLine("전설의검 구매!");
                gold -= 700;
                sword = "전설의검";
                Console.WriteLine("남은 소지금 : " + gold);
            }
            Console.Write("캐릭터 이름을 입력해주세요 : ");
            input = Console.ReadLine();
            string name = input;
            Console.WriteLine("무기 : " + sword);
            Console.WriteLine(name + " 공격력 : 100 + "+ 
                (sword == "무한의대검" ? 1 : (sword == "카타나" ? 2 :
                (sword == "진은검" ? 3 : (sword == "집판검" ? 4 : 
                (sword == "엑스칼리버" ? 5 : (sword == "유령검" ? 6 : 7)))))));

        }
    }
}
