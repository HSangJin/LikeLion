using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace study22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램 종료");
            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH : {path}");
            //Environment.Exit(0);


            //Random rand = new Random();
            //int ranNumber = rand.Next(1, 101); //1에서 100까지
            //Console.WriteLine("랜덤 숫자 : " + ranNumber);


            ////프로그램 실행 시간 구하기
            //Stopwatch sw = Stopwatch.StartNew();
            ////실행코드
            //for(int i=0;i<100;i++)
            //{
            //    Thread.Sleep(1);
            //}
            //sw.Stop();
            //Console.WriteLine($"for 시간 : {sw.ElapsedMilliseconds}ms");


            //string input = "Hello, my phone number is 010-1234-5678";
            //string patter = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴

            //bool isMath = Regex.IsMatch(input, patter);
            //Console.WriteLine($"전화번호가 존재 하는가? {isMath}");


            //클래스시그니처 기본구성
            //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다
            //[접근 지정자] [수정자] class 클래스이름 : 부모클래스, 인터페이스
            //지정자 public private protected internal // BaseClass, IComparable
            //수정자 abstract sealed static partial


            ////값형식과 참조형식
            ////값형식은 스택에 저장되고, 참조형식은 힙에 저장됩니다.
            //int valueType = 10;
            //object referenceType = valueType;
            //valueType = 20;
            //Console.WriteLine($"valueType : {valueType}"); //20
            //Console.WriteLine($"referenceType : {referenceType}"); //


            ////박싱 언박싱
            ////값형식을 참조형식으로 변환(박싱), 다시 값형식으로 변환(언박싱)
            //int value = 42;
            //object boxed = value; //박싱
            //int unboxed = (int)boxed; //언박싱

            //Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");


            ////is 연상자 형식 비교하기
            ////객체가 특정 형식인지 확인할수있다.
            //object obj = "Hello";
            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); // false

            ////as 연산자로 형식 변환하기
            ////as 연산자를 사용하여 안전하게 형 변환을 수행한다.
            //string str = obj as string;
            //Console.WriteLine(str is string);


            //object obj = 42;
            //var obj2 = 42;
            //if (obj is int number) Console.WriteLine($"Number : {number}");
            //else Console.WriteLine("Not a number");

            //if (obj2 is int num) Console.WriteLine($"Number : {num}");
            //else Console.WriteLine("Not a number");


            ////문자열 다루기
            //string greeting = "Hello";
            //string name = "Alice";
            //string message = greeting +", "+name+"!";
            //Console.WriteLine(message);
            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열

            ////string 다양한 메서드
            //string text = "C# is awesome!";
            //Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");
            //Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            //Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            //Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "greate")}");

            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());


            ////String과 StringBuilder클래스 성능차이 비교
            ////반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.
            //int iterations = 100000;
            //Stopwatch sw = Stopwatch.StartNew();
            //string text = "";
            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "a";
            //}
            //sw.Stop();
            //Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

            //sw.Restart();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < iterations; i++)
            //{
            //    sb.Append("a");
            //}

            //sw.Stop();
            //Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}");


            //예외처리하기
            //예외는 프로그램실행중 발행하는 오류입니다. 예외를 처리하면 프로그램이 중단되지 않고
            //실행을 계속 할수있습니다.
            //try catch

            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]);
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine($"Error : {e.Message}");
            //}


            ////finally 블록은 예외 발생여부와 상관없이 항상 실행됩니다.
            //try
            //{
            //    int number = int.Parse("NotANumber"); //오류발생
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine($"Format Error: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("항상 실행됩니다.");
            //}


            ////Exception 클래스
            ////모든예외의 기본 클래스입니다.
            //try
            //{
            //    int number = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"General Error : {ex.Message}");
            //}

            //try
            //{
            //    int age = -5;
            //    if(age < 0)
            //    {
            //        throw new ArgumentException("Age cannot be negative");
            //    }
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine($"Exception : {ex.Message}");
            //}

            ////배열과 컬랙션
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            ////배열과 비슷하지만 동적으로 크기가 변하는 가별 길이 컬랙션
            //List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");
            //names.Remove("Bob");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);
            //list[2] = 200;
            //list.Remove(3);

            //Console.WriteLine(list[0]);
            //Console.WriteLine(list.Count);


            ////Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //while(queue.Count>0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Queue queue = new Queue();
            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            ////ArrayList 생성
            ////크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            //ArrayList arrayList = new ArrayList();
            ////요소추가
            //arrayList.Add(1);       //정수
            //arrayList.Add("Hello"); //문자열
            //arrayList.Add(3.14);    //실수
            ////요소접근
            //Console.WriteLine("ArrayList 요소 : ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            ////요소제거
            //arrayList.Remove(1);
            //Console.WriteLine("\nArrayList 요소 제거 후 : ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            ////Hashtable 클래스
            ////키-값 쌍을 저장하는 컬렉션이다.
            ////키를 이용해 값을 빠르게 검색
            //Hashtable hashtable = new Hashtable();
            ////키-값 쌍 추가
            //hashtable["Alice"] = 25;
            //hashtable["Bob"] = 30;
            //hashtable["포션"] = 20;

            //Console.WriteLine("Hashtable 요소:");
            //foreach(DictionaryEntry en in hashtable)
            //{
            //    Console.WriteLine($"Key : {en.Key}, Value : {en.Value}");
            //}

            ////특정 키의 값 가져오기
            //Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");
            ////요소제거
            //hashtable.Remove("Bob");
            //Console.WriteLine("Hashtable 요소:");
            //foreach (DictionaryEntry en in hashtable)
            //{
            //    Console.WriteLine($"Key : {en.Key}, Value : {en.Value}");
            //}


            ////제네릭 사용하기(Generics)
            ////<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있습니다.
            //Cup<string> cupOfString = new Cup<string>() { Content = "Coffee" };
            //Cup<int> cupOfInf = new Cup<int>() { Content = 42 };

            //Console.WriteLine($"CupOfString: {cupOfString.Content}");
            //Console.WriteLine($"CupOfInt: {cupOfInf.Content}");


            //Stack<int> stack = new Stack<int>();
            //stack.Push(10); 
            //stack.Push(20);
            //stack.Push(30);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}


            //List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            ////IEnumerator
            ////C#컬렉션 순회 반복할수있는 인터페이스
            //ArrayList list = new ArrayList() { "Apple", "Banana", "Cherry" };
            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


            //var collection = new SimpleCollection();
            //foreach(var i in collection)
            //{
            //    Console.WriteLine(i);
            //}


            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}


            ////null값
            ////참조형식 null을 가질수 있으며, 값 형식은 기본적으로 null을 가질수없습니다.
            //string str = null;
            //if(str == null)
            //{
            //    Console.WriteLine("str is null");
            //}

            //int? nullableInt = null;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            //nullableInt = 10;
            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            ////null 값을 다루는 연산자 소개하기 ??, ? 연산자
            ////?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?은 null안전 접근을 합니다.
            //string _str = null;
            //Console.WriteLine(_str ?? "DefaultValue"); //_str이 null이면 "Default Value"
            //_str = "Hello";
            //Console.WriteLine(str?.Length);


            ////LINQ는 확장메서드 형태로 제공된다.
            ////LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할수있습니다.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //foreach(var n in evenNumbers)
            //{
            //    Console.WriteLine(n);
            //}
        }

        //class SimpleCollection : IEnumerable<int>
        //{
        //    private int[] data = { 1, 2, 3, 4, 5 };
        //    public IEnumerator<int> GetEnumerator()
        //    {
        //        foreach (var item in data)
        //        {
        //            yield return item;
        //        }
        //    }

        //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        //}

        //class Cup<T>
        //{
        //    public T Content { get; set; }
        //}

        ////기본 클래스
        //public class Player
        //{
        //    public string name { get; set; }
        //    public int score { get; set; }
        //}

        ////상속하는 클래스
        //public class Warrior : Player
        //{
        //    public int strength { get; set; }
        //}

        ////인터페이스 구현하는 클래스
        //public class Enemy: IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }
        //}

        //public interface IAttackable { void Attack(); }

        //public interface IMovable { void Move(); }

        ////추상 클래스 (abstract)
        //public abstract class Animal
        //{
        //    public abstract void MakeSound();
        //}
    }
}
