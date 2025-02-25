using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 6;

            //switch(day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;
            //}


            ////문제1. 세 정수의 최대값 구하기
            ////문제설명:
            ////사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            ////요구사항:
            ////사용자에게 세 개의 정수를 입력받습니다.
            ////if문을 사용하여 가장 큰 정수를 결정합니다.
            ////결과를 "최대값: X" 형식으로 출력합니다.

            ////사용자로부터 3개의 정수를 입력받는다.
            //Console.Write("첫 번째 정수를 입력하세요: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("두 번째 정수를 입력하세요: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("세 번째 정수를 입력하세요: ");
            //int c = int.Parse(Console.ReadLine());

            ////if문을 사용하여 최대값 구한다.
            //int max = a; //초기 최대값을 a로 설정
            //if (b > max)
            //    max = b;
            //if (c > max)
            //    max = c;

            ////결과 출력
            //Console.WriteLine("최대값 : " + max);


            ////학생의 점수를 입력받는다.
            //Console.Write("학생의 점수를 입력하세요 (0 ~ 100): ");
            //int score = int.Parse(Console.ReadLine());
            //string grade;

            ////if-else if문을 사용하여 점수에 따른 학점을 결정한다.
            //if (score >= 90)
            //    grade = "A";
            //else if (score >= 80)
            //    grade = "B";
            //else if (score >= 70)
            //    grade = "C";
            //else if (score >= 60)
            //    grade = "D";
            //else
            //    grade = "F";

            ////결과 출력
            //Console.WriteLine("학점 : " + grade);


            ////사용자로 부터 두 개의 숫자를 입력받는다.
            //Console.Write("첫 번째 숫자를 입력하세요 : ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : ");
            //double num2 = double.Parse(Console.ReadLine());

            ////사용자로부터 연산자를 입력받는다.
            //Console.Write("연산자 (+,-,*,/) 를 입력하세요: ");
            //char op = Console.ReadLine()[0];
            //double result = 0;
            //bool valid = true;

            ////입력받은 연산자에 따라 if문을 사용해 연산을 수행한다.
            //if (op == '+')
            //{
            //    result = num1 + num2;
            //}
            //else if (op == '-')
            //{
            //    result = num1 - num2;
            //}
            //else if (op == '*')
            //{
            //    result = num1 * num2;
            //}
            //else if (op == '/')
            //{
            //    //0으로 나누는 경우를 체크
            //    if(num2 != 0)
            //    {
            //        result = num1 / num2;
            //    }
            //    else
            //    {
            //        Console.WriteLine("0으로 나눌수 없습니다.");
            //        valid = false;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘모소딘 연산자 입니다.");
            //    valid = false;
            //}

            ////연산이 정상적으로 수행되었으면 결과 출력
            //if (valid)
            //    Console.WriteLine("결과: " + result);


            ////캐릭터를 선택하세요. (1.검사 2.마법사 3.도적)
            ////스위치문 사용해보자
            //int iInput = 0;
            //Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적)");
            //iInput = int.Parse(Console.ReadLine());

            //switch(iInput)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;
            //}


            ////반복문
            ////초기화 / 조건문 / 증감식
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}


            ////무한반복
            //for (; ; )
            //{
            //    Console.WriteLine("중요한건 꺽이지 않는 마음");
            //    Thread.Sleep(500);
            //} 

            //0~9까지 출력하기 성공
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine(i);
            //}


            ////1~10까지의 합 구하기
            //int sum = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine(sum + " + " + i + " = " + (sum + i));
            //    sum += i;
            //}
            //Console.WriteLine("합 : " + sum);


            //int count = 1;
            //while(count<=5)
            //{
            //    Console.WriteLine("Count : " + count);
            //    count++; //증가,감소
            //    if(count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}
            //Console.WriteLine("Count : " + count);


            ////랜덤
            //Random random = new Random(); //Random 객체를 생성한다.
            //for(int i=0;i<10;i++)
            //{
            //    //0이상 10미만의 랜덤 정수 생성
            //    int randomNumber = random.Next(0, 10);
            //    Console.WriteLine("0이상 10미만의 랜덤 정수 : " + randomNumber);
            //    double randomDouble = random.NextDouble();
            //    Console.WriteLine("랜덤 실수 : " + randomDouble);
            //}


            ////대장장이 키우기
            ////도끼등급 SSS  10%
            ////도끼등급 SS   40%
            ////도끼등급 S    50%
            //Console.WriteLine("대장장이 키우기");
            //Random ran = new Random();

            //Console.Write("뽑기 숫자를 입력해주세요 : ");
            //int count = int.Parse(Console.ReadLine());
            //for(int i=0;i<count;i++)
            //{
            //    double persent = ran.NextDouble();
            //    persent *= 100;
            //    if (persent <= 10)
            //    {
            //        Console.WriteLine("당첨: 도끼등급 SSS");
            //    }
            //    else if (persent <= 40)
            //    {
            //        Console.WriteLine("당첨: 도끼등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("당첨: 도끼등급 S");
            //    }
            //    Thread.Sleep(500);
            //    //Console.WriteLine("persent : " + persent);
            //}


            ////do while
            ////1회 무조건 실행하고 while문과 같이 조건 진행
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한번은 실행 됩니다.");
            //    x--;
            //} while (x > 0);


            ////break문
            ////반목문을 탈출할수있다.
            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}


            ////continue
            ////현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            //for(int i = 1;i<=10;i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i); //홀수만 출력
            //}


        //    //goto
        //    int n = 1;
        //start:
        //    if (n <= 5)
        //    {
        //        Console.WriteLine(n);
        //        n++;
        //        goto start; //레이블로 이동
        //    }


        }
    }
}
