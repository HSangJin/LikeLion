using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;

namespace Hello
{
    class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}

namespace study35
{
    class Person
    {
        private string name = "홍길동"; //필드 클래스의 데이터를 저장하는 멤버입니다.
        public int age { get; private set; }
        public void SetName(string n) { name = n; }
        public string GetName() { return name; }

        public Person()
        {
            name = "Unknown";
            age = 0;
        }

        public Person(string name)
        {
            this.name = name;
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }

    class Program
    {
        //메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {
            //Say say = new Say();
            //say.SayHello();


            //Person p = new Person();
            ////p.SetName("Alice");
            //Person p1 = new Person("Bob"); //1개짜리 매개변수 있는 생성자
            //Person p2 = new Person("카타리나", 20); //2개짜리 매개변수 있는 생성자
            //Console.WriteLine(p.GetName()+","+p.age);
            //Console.WriteLine(p1.GetName() + "," + p1.age);
            //Console.WriteLine(p2.GetName() + "," + p2.age);


            //MyResource r = new MyResource();
            ////GC에 의해 나중에 소멸자 호출
            ////가비지 컬렉션은 더이상 참조되지 않는 객체를 정리합니다.


            //int a = 10;
            //int b = 20;
            ////Increase(ref a);
            ////Console.WriteLine("A의 값 : " + a);
            //int x, y;
            //OutFunc(a, b,out x, out y);
            //Console.WriteLine("x : " + x + "y : " + y);


            //Animal myDog = new Dog();
            //myDog.MakeSound(); //멍멍
            //myDog.Sleep();

            //Animal myCat = new Cat();
            //myCat.MakeSound();
            //myCat.Sleep();


            //Child child = new Child();


            Console.WriteLine("간단한 RPG 게임을 시작합니다.");
            //캐릭터 생성
            GameCharacter warrior = new Warrior("전사");
            GameCharacter mage = new Mage("마법사");
            //전투 시뮬
            Console.WriteLine("=====전투 시작!=====");
            //전사의 공격
            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);
            //마법사의 반격
            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("=========전투종료=======");
            Console.WriteLine($"전사 남은 체력: {warrior.Health}");
            Console.WriteLine($"마법사 남은 체력: {mage.Health}");
        }
    }

    ////추상 클래스를 상속받아 구체적인 클래스 구현
    //class Dog : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("멍멍");
    //    }
    //}

    //class Cat : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("야옹");
    //    }
    //}

    ////추상클래스 (Abstract Class)
    ////추상클래스는 객체를 생성할수없는 클래스로, 상속을 통해서만 사용할수있습니다.
    ////공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할때 사용됩니다.
    ////abstract 키워드를 사용
    ////추상 메서드는 선언만 하고, 구현은하지 않습니다.
    ////상속받은 클래스는 반드시 구현해야한다.
    //abstract class Animal
    //{
    //    //추상 메서드 (구현X, 상속받은 클래스가 구현)
    //    public abstract void MakeSound();

    //    //일반 메서드(공통 기능 제공)
    //    public void Sleep()
    //    {
    //        Console.WriteLine("동물이 잠을 잡니다.");
    //    }
    //}

    ////부모생성자 호출
    //class Parent
    //{
    //    public Parent(string message)
    //    {
    //        Console.WriteLine("부모생성자" + message);
    //    }
    //}

    //class Child : Parent
    //{
    //    public Child():base("하하하하성공")
    //    {
    //        Console.WriteLine("자식 생성자 호출");
    //    }
    //}

    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        protected GameCharacter(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        //추상메서드 : 모든 캐릭터가 구현해야 하는 기본 공격
        public abstract void BasicAttack(GameCharacter target);

        //추상메서드 : 모든 캐릭터가 구현해야하는 특수 공격
        public abstract void SpecialAttack(GameCharacter target);

        //일반 메서드 : 모든 캐릭터가 공유하는 기능
        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);
            Health = Math.Max(0, Health - actualDamage);
            Console.WriteLine($"{Name}이 {actualDamage}의 피해를 받았습니다. 남은체력 : {Health}");
        }
    }


    public class Mage : GameCharacter
    {
        public Mage(string name) : base(name, 80, 20, 5)
        {

        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 마법 구체를 던집니다!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 화염 폭발을 시전합니다.");
            target.TakeDamage(Attack*2);
        }
    }

    class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        { }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 기본 공격을 시도합니다.!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 휠윈드 시전합니다.");
            target.TakeDamage(Attack*2);
        }
    }
}
