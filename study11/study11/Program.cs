using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study11
{
    class Program
    {
        //1단계 함수
        //반환형 함수이름(매개변수)
        //{
        //}

        //static void Loading()
        //{
        //    Console.WriteLine("로딩화면");
        //    Thread.Sleep(3000);
        //    Console.WriteLine("로딩끝");
        //}

        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 : " + _Attack);
        }

        //3단계
        //출력
        static int BaseAttack()
        {
            //기본공격력 10
            int attack = 10;

            return attack; //출력
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Loading();

            //Console.WriteLine("게임이 시작됩니다.");
            //Console.ReadLine();


            //int Attack = 0;
            //int bAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //int.TryParse(Console.ReadLine(), out Attack);

            ////기본공격력
            //bAttack = BaseAttack();

            //AttackFunction(Attack+bAttack);


            ////두수를 더하는 함수 만들어서 오류를 해결하세요.
            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 = {result}");


            //string[] fuits = { "사과", "바나나", "체리" };
            ////반복문
            //foreach(string fruit in fuits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //1. 배열 관련 문제(3문제)
            //배열을 선언하고, 값을 저장/출력하는 연습

            Console.WriteLine("Q1. 배열 요소 출력");
            // 복사
            int[] ints = { 10, 20, 30, 40, 50 };
            // 편집
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine("\n");
            // 10 20 30 40 50


            Console.WriteLine("Q2. 배열 요소 합 구하기");
            // 복사
            // 편집
            // 문제: 사용자가 5개의 정수를 입력하면, 배열에 저장하고, 모든 수의 합을 출력하세요.
            // 예상 입력/출력

            //복사
            int[] nums = new int[5];
            try
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("숫자 입력: ");
                    nums[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            //편집
            int sum = nums.Sum();
            Console.WriteLine("총 합: " + sum + "\n");
            //숫자 입력: 1 2 3 4 5
            //총 합: 15


            Console.WriteLine("Q3. 최대값 찾기");
            // 복사
            // 편집
            // 문제: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            // 예상출력

            //makefile
            int[] numbers = { 3, 8, 15, 6, 2 };
            //복사
            int Maxs(int[] _numm)
            {
                int _max = 0;
                for(int i=0;i< _numm.Length; i++)
                {
                    if (_max < _numm[i])
                    {
                        _max = _numm[i];
                    }
                }
                return _max;
            }
            //편집
            int max = Maxs(numbers);
            //최대값: 15
            Console.WriteLine("최대값: " + max + "\n");


            //2. 반복문 관련 문제(3문제)
            //for / while / foreach 반복문을 연습하는 문제

            Console.WriteLine("Q4. 1부터 10까지 출력(for문)");
            //복사
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //편집
            for (int i = 0; i < integers.Length; i++)
            {
                Console.Write(integers[i] + " ");
            }
            //1 2 3 4 5 6 7 8 9 10
            Console.WriteLine("\n");


            Console.WriteLine("Q5. 짝수만 출력(while문)");
            //문제: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
            //예상출력

            //복사
            int index = 1;
            //편집
            while (index <= 10)
            {
                if (index % 2 == 0)
                {
                    Console.Write(index + " ");
                }
                index++;
            }
            //2 4 6 8 10
            Console.WriteLine("\n");


            Console.WriteLine("Q6. 배열 요소 출력(foreach문)");
            //복사
            int[] iNums = { 1, 2, 3, 4, 5 };
            //편집
            foreach (int _num in iNums)
            {
                Console.Write(_num + " ");
            }
            //1 2 3 4 5
            Console.WriteLine("\n");

            //3. 함수 관련 문제(3문제)
            //함수를 선언하고, 매개변수와 반환값을 연습하는 문제

            Console.WriteLine("Q7. 두 수의 합을 구하는 함수");
            //복사
            int a = 3;
            int b = 5;
            //편집
            int Sum(int _a, int _b)
            {
                return _a + _b;
            }
            //3과 5의 합: 8
            Console.WriteLine($"{a}과 {b}의 합: {Sum(a, b)}\n");


            Console.WriteLine("Q8. 문자열 길이 반환 함수");
            // 문제: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
            // 예상출력

            // 복사
            string str = default;
            // 편집
            int Length(string _str)
            {
                return _str.Length;
            }
            // 문자열 입력: Hello
            str = Console.ReadLine();
            // 문자열 길이: 5
            Console.WriteLine("문자열 입력: " + str);
            Console.WriteLine("문자열 길이: " + Length(str) + "\n");


            Console.WriteLine("Q9. 가장 큰 수 반환 함수");
            // 문제: 세개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
            // 예상출력

            //복사
            int iNumber1 = 0, iNumber2 = 0, iNumber3 = 0;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("숫자 입력: ");
                    switch(i)
                    {
                        case 0:
                            iNumber1 = int.Parse(Console.ReadLine());
                            break;
                        case 1:
                            iNumber2 = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            iNumber3 = int.Parse(Console.ReadLine());
                            break;
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            //편집
            int Max(int _num1, int _num2, int _num3)
            {
                int _max = 0;
                if (_max < _num1)
                {
                    _max = _num1;
                }

                if (_max < _num2)
                {
                    _max = _num2;
                }

                if (_max < _num3)
                {
                    _max = _num3;
                }

                return _max;
            }
            //가장 큰 수: 7
            Console.WriteLine("가장 큰 수: " + Max(iNumber1, iNumber2, iNumber3) + "\n");
        }
    }
}
