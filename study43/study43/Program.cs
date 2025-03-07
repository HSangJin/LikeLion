using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study43
{
    //C# 인터페이스(Interface)란?
    //인터페이스는 클래스나 구조체에서 구현해야하는 메서드, 속성 등을 정의하는 추상적인 개념입니다.
    //즉, 어떤 기능을 반드시 포함하도록 강제하는 역할을 합니다.

    //인터페이스의 특징
    //interface 키워드를 사용해서 정의
    //추상 메서드만 포함(구현X)-> 인터페이스를 구현하는 클래스에서 반드시 구현해야함.
    //다중 상속 가능(C#에서는 클래스 다중상속이 불가능하지만, 인터페이스는 여러개 구현 가능)
    //객체를 생성할수없음(추상 클래스와 유사).

    ////인터페이스 정의
    //interface IAnimal
    //{
    //    void MakeSound(); //인터페이스의 메서드 (구현 x)

    //}

    ////인터페이스 구현(클레스에서 반드시 구현해야함)
    //class Dog : IAnimal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("멍멍!");
    //    }
    //}

    //class Cat : IAnimal
    //{
    //    public void MakeSound()
    //    {
    //        Console.WriteLine("야옹");
    //    }
    //}

    public interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak() { Console.WriteLine("멍멍"); }
    }

    class Cat : IAnimal
    {
        public void Speak() { Console.WriteLine("야옹"); }
    }

    //Train(IAnimal animal) 메서드는 Dog, Cat 모두 받을수있음 -> 코드 재사용성 증가
    //추가적인 IAnimal을 구현한 새로운 동물이 생기더라도 Train() 메서드는 변경할 필요없음 -> 유지보수 용이
    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.WriteLine("동물이 소리를 냅니다.");
            animal.Speak();
        }
    }

    //인터페이스를 사용하면 기존 코드 변경없이 새로운 기능 추가가 가능함
    //다양한 결제 시스템 추가(Open-Closed Principle)

    public interface IPayment
    {
        void ProcessPayment();
    }

    //신용카드 결제 클래스
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment() { Console.WriteLine("신용카드 결제 완료!"); }
    }

    //결제처리기
    class PaymentProcessor
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }

    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal 결제완료");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IAnimal dog = new Dog();
            //dog.MakeSound();

            //IAnimal cat = new Cat();
            //cat.MakeSound();

            //AnimalTrainer trainer = new AnimalTrainer();
            //IAnimal myDog = new Dog();
            //IAnimal myCat = new Cat();

            //trainer.Train(myDog);
            //trainer.Train(myCat);


            PaymentProcessor processor = new PaymentProcessor();
            IPayment creaditCard = new CreditCardPayment();
            IPayment payPal = new PayPalPayment();
            processor.Pay(creaditCard);
            payPal.ProcessPayment();
        }
    }
}
