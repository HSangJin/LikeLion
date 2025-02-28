using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study17
{
    //class Person
    //{
    //    public string name;
    //    public int age;

    //    //기본생성자
    //    //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
    //    //클래스와 같은이름을 가지며, 반환형이 없다 (void도 사용하지 않음)
    //    //객체를 만들때 필요한 초기값을 설정할때 사용 많이 한다.

    //    public Person()
    //    {
    //        this.name = "이름 없음";
    //        this.age = 0;
    //        Console.WriteLine("기본 생성자가 실행됨");
    //    }

    //    public Person(string _name, int _age)
    //    {
    //        this.name = _name;
    //        this.age = _age;
    //        Console.WriteLine("기본 생성자가 실행됨");
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {name}, 나이 : {age}");
    //    }
    //}

    //class Marine
    //{
    //    public string name;
    //    public int mineral = 0;

    //    public Marine()
    //    {
    //        name = "marine";
    //        mineral = 50;
    //    }

    //    public Marine(string name, int mineral)
    //    {
    //        this.name = name;
    //        this.mineral = mineral;
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
    //    }
    //}

    //class SCV
    //{
    //    public string name;
    //    public int mineral;

    //    public SCV()
    //    {
    //        name = "SCV";
    //        mineral = 50;
    //    }

    //    public SCV(string name, int mineral)
    //    {
    //        this.name = name;
    //        this.mineral = mineral;
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
    //    }
    //}

    //class Barrack
    //{
    //    public string name;
    //    public int mineral;
    //    public Barrack()
    //    {
    //        name = "배럭";
    //        mineral = 150;
    //    }
    //    public Barrack(string name, int mineral)
    //    {
    //        this.name = name;
    //        this.mineral = mineral;
    //    }
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
    //    }
    //}

    //class Mineral
    //{
    //    public int count;

    //    public Mineral()
    //    {
    //        count = 1500;
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"현재 미네랄 갯수 : {count}");
    //    }
    //}

    //class Game
    //{
    //    public static int mineral;
    //    public static int gas;
    //    public static int charCount;

    //    public static void ShowInfo()
    //    {
    //        Console.WriteLine($"미네랄 : {mineral}, 가스 : {gas}, 인구 수 : {charCount}");
    //    }
    //}


    //class Person
    //{
    //    private string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    //값 설정하기 (setter)
    //    public void SetName(string name)
    //    {
    //        this.name = name;
    //    }

    //    //값 가져오기 (getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }
    //}


    ////C# 프로퍼티 property
    //class Person
    //{
    //    private string name;
    //    public string Name
    //    {
    //        get { return name; }    //getter
    //        set { name = value; }   //setter
    //    }
    //}


    class Person
    {
        private int count = 100;
        public string Name { get; set; }
        public int Count { get { return count; } } //읽기전용
        public float Balance { get; private set; } //쓰기전용

        public void AddBal() { Balance += 100; }
    }

    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; private set; } = 100;
    }


    class Program
    {
        static void Main(string[] args)
        {

            //DateTime now = DateTime.Now;
            //Console.Clear();
            //Console.WriteLine($"Current Date and Time : {now}");

            //TimeSpan durateion = new TimeSpan(10, 30, 0); //1시간 30분
            //Console.WriteLine($"Duration : {durateion}");

            ////클래스
            //Person p = new Person(); //객체 생성 instance
            //p.ShowInfo();

            //Person p1 = new Person("홍길동", 20);
            //p1.ShowInfo();
            //Person p2 = new Person("영희", 30);
            //p2.ShowInfo();


            //Game.mineral = 50;
            //Game.gas = 0;
            //Game.charCount = 4;
            //Game.ShowInfo();

            //Marine marin = new Marine("불꽃테란", 100);
            //SCV scv = new SCV("열받은SCV", 70);
            //Barrack barrack = new Barrack();
            ////클래스의 배열
            //Mineral[] minerals = new Mineral[7]
            ////{
            ////    new Mineral(), new Mineral(), new Mineral(),
            ////    new Mineral(), new Mineral(), new Mineral(),
            ////    new Mineral()
            ////}
            //;

            //for(int i=0;i<minerals.Length; i++)
            //{
            //    minerals[i] = new Mineral();
            //    minerals[i].ShowInfo();
            //}

            //marin.ShowInfo();
            //scv.ShowInfo();


            Person p = new Person();
            p.Name = "홍길동";
            p.AddBal();
            Console.WriteLine("이름 : "+p.Name+" Count : "+p.Count+" Balance : "+p.Balance);

            Marin m = new Marin();
            Console.WriteLine("이름 : " + m.Name + " 미네랄 : " + m.Mineral);
        }
    }
}
