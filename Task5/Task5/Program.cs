using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public void Strength()
        {
            Console.WriteLine($"Name : {Name}, Score : {Score}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. 클래스와 상속");
            Warrior warrior = new Warrior();
            warrior.Name = "전사";
            warrior.Score = 100;
            warrior.Strength();
            Console.WriteLine();

            Console.WriteLine("2. 예외 처리");
            int? num = null;
            while (num == null)
            {
                Console.Write("정수를 입력하세요: ");
                string _input = Console.ReadLine();

                try
                {
                    num = int.Parse(_input);
                    Console.WriteLine("\n입력한 정수 : " + num);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("\n올바른 숫자를 입력하세요.");
                }
            }
            Console.WriteLine();

            Console.WriteLine("3. 컬렉션(List, Queue, Stack) 활용");
            List<string> fruits = new List<string>();
            fruits.Add("사과");
            fruits.Add("바나나");
            fruits.Add("포도");
            foreach (var fruit in fruits)
                Console.WriteLine("과일: " + fruit);
            Console.WriteLine();
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("첫 번째 작업");
            tasks.Enqueue("두 번째 작업");
            tasks.Enqueue("세 번째 작업");
            foreach (var task in tasks)
                Console.WriteLine("현 작업: " + task);
            Console.WriteLine();
            Stack<int> nums = new Stack<int>();
            nums.Push(10);
            nums.Push(20);
            nums.Push(30);
            foreach (var _num in nums)
                Console.WriteLine("숫자: " + _num);
            Console.WriteLine();

            Console.WriteLine("4. 문자열 처리");
            Console.Write("\n문자열을 입력해주세요 ex)\"Hello, C# World!\": ");
            string input = Console.ReadLine();
            Console.WriteLine("대문자 변환: "+input.ToUpper());
            Console.WriteLine("문자 변경: "+input.Replace("#", "Sharp"));
            Console.WriteLine("문자열 길이: " + input.Length);
            Console.WriteLine();

            Console.WriteLine("5. Linq 활용");
            Console.WriteLine();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list = numbers.Where(n=>n%2==0).ToList();
            foreach (int n in list) 
                Console.WriteLine("리스트 출력: "+n);
            Console.WriteLine("모든 숫자의 합: "+numbers.Sum());

        }
    }
}
