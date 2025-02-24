using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1. 세정수의 최대값 구하기
            //문제설명:
            //사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            //요구사항:
            //사용자에게서 세 개의 정수를 입력받습니다.
            //if문을 사용하여 가장 큰 정수를 결정합니다.
            //결과를 "최대값: X"형식으로 출력합니다.

            Console.WriteLine("문제1. 세정수의 최대값 구하기");
            int i1 = default, i2 = default, i3 = default; 
            Console.Clear();
            Console.WriteLine("세개의 정수를 입력해주세요(0/3)");
            Console.Write("첫번째 정수 : ");
            string input = Console.ReadLine();
            try { i1 = int.Parse(input); }
            catch(Exception e)
            {
                Console.WriteLine("정수 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            //Console.Clear();
            Console.WriteLine("세개의 정수를 입력해주세요(1/3)");
            Console.Write("두번째 정수 : ");
            input = Console.ReadLine();
            try { i2 = int.Parse(input); }
            catch (Exception e)
            {
                Console.WriteLine("정수 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            //Console.Clear();
            Console.WriteLine("세개의 정수를 입력해주세요(2/3)");
            Console.Write("세번째 정수 : ");
            input = Console.ReadLine();
            try { i3 = int.Parse(input); }
            catch (Exception e)
            {
                Console.WriteLine("정수 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            int max = (i1 > i2) ? 
                            (i1 > i3) ? i1 : i3
                            : (i2 > i3) ? i2 : i3;
            Console.WriteLine("최대값: "+max);
            Console.WriteLine("");

            //문제2. 점수에 따른 학점 평가
            //문제 설명:
            //학생의 점수를 입력받아 아래 기준에 따라 학점을 츨력하는 프로그램을 작성하세요.
            // 90이상 : A 학점
            // 80이상 90미만 : B 학점
            // 70이상 80미만 : C 학점
            // 60이상 70미만 : D 학점
            // 60미만 : F 학점

            Console.WriteLine("문제2. 점수에 따른 학점 평가");
            Console.Write("학점을 입력해주세요 : ");
            input = Console.ReadLine();
            int unit = default;
            try { unit = int.Parse(input); }
            catch(Exception e)
            {
                Console.WriteLine("정수 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            if (unit >= 90)
            {
                Console.WriteLine("당신의 학점은 A 학점 입니다.");
            }
            else if(unit >= 80)
            {
                Console.WriteLine("당신의 학점은 B 학점 입니다.");
            }
            else if(unit >= 70)
            {
                Console.WriteLine("당신의 학점은 C 학점 입니다.");
            }
            else if(unit >= 60)
            {
                Console.WriteLine("당신의 학점은 D 학점 입니다.");
            }
            else
            {
                Console.WriteLine("당신의 학점은 F 학점 입니다.");
            }
            Console.WriteLine("");

            //문제3. 간단한 사칙연산 계산기
            //문제설명:
            //사용자로부터 두 개의 숫자와 연산자(+,-,*,/)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            //요구사항:
            //두개의 숫자와 연산자 기호를 입력받습니다.
            //if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            //나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            //결과는 "결과: X"형식으로 출력합니다.

            Console.WriteLine("문제3. 간단한 사칙연산 계산기");
            Console.WriteLine("두개의 숫자를 입력해주세요(0/2)");
            Console.Write("첫번째 숫자 : ");
            input = Console.ReadLine();
            double n1 = default, n2 = default;
            string op = default;
            try { n1 = double.Parse(input); }
            catch (Exception e)
            {
                Console.WriteLine("첫번째 숫자 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            Console.WriteLine("두개의 숫자를 입력해주세요(1/2)");
            Console.Write("두번째 숫자 : ");
            input = Console.ReadLine();
            try { n2 = double.Parse(input); }
            catch (Exception e)
            {
                Console.WriteLine("두번째 숫자 변환 실패 에러");
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("");

            Console.WriteLine("연산자를 입력해주세요(+,-,*,/) : ");
            Console.Write("연산자 : ");
            op = Console.ReadLine();
            Console.WriteLine("");
            if (op == "+")
            {
                Console.WriteLine("결과: " + (n1 + n2));
            }
            else if (op == "-")
            {
                Console.WriteLine("결과: " + (n1 - n2));
            }
            else if (op == "*")
            {
                Console.WriteLine("결과: " + (n1 * n2));
            }
            else if (op == "/")
            {
                if(n2 == 0)
                {
                    Console.WriteLine(" [ 에러 ] 0으로 숫자를 나눌수없어 프로그램을 종료합니다.");
                }
                else
                {
                    Console.WriteLine("결과: " + (n1 / n2));
                }
            }
            else
            {
                Console.WriteLine("연산자가 아닌 값을 입력하셨습니다.");
            }
            Console.WriteLine("");
        }
    }
}
