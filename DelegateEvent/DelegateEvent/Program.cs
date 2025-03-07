using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    //게임 캐릭터 클래스
    class Character
    {
        //속성
        public string Name { get; private set; } //캐릭터 이름
        public int Health { get; private set; } //캐릭터 체력

        //이벤트 정의 - 캐릭터가 데미지를 입었을때 발생
        //EventHandler는 C#에서 제공하는 기본 델리게이트 타입
        //이벤트는 외부에서 직접 호출 할수없고, +=와 -=연산자로만 접근 가능
        public event EventHandler OnDamaged;

        //생성자
        public Character(string name, int health) { Name = name; Health = health; }

        //데미지를 입는 메서드
        public void TakeDamage(int amount)
        {
            //체력 감소
            Health -= amount;
            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력 : {Health}");
            //이벤트 발생 (구독자가 있는 경우에만)
            //?. 연산자는 OnDamaged가 null이 아닐때만 Invoke 메서드 호출
            //EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        //델리게이트 정의 - 메세지 출력을 위한 메서드 참조
        //string 매개변수를 받고 반환값이 없는 (void) 메서드를 참조 할수있는 타입
        delegate void MessageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드 형과 타입 이런게 일치해야 받아줌
        static void DisplayMessage(string message) { Console.WriteLine($"메세지 : {message}"); }
        static void DisplayUpperMessage(string message) { Console.WriteLine($"대문자 메세지: {message.ToUpper()}"); }


        //이벤트 핸들러 메서드
        //EventHandler 델리게이트와 일치하는 시그니처를 가져야함
        //sender : 이벤트 발생시킨 객체(여기서는 Character객체)
        //e: 이벤트와 관련된 추가 데이터(여기서는 사용하지 않음)
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //sender를 character타입으로 형변환
            Character character = (Character)sender;
            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다.! "+
                $"현재 체력 : {character.Health}");
        }

        //델리게이트와 이벤트를 더 쉽게 만든 Action
        static void SayHello() { Console.WriteLine("안녕하세요"); }
        static void ShowNotification() { Console.WriteLine("중요한 알림이 있습니다."); }
        static void HelloWorld(string message) { Console.WriteLine($"신규메세지{message}"); }

        static void Main(string[] args)
        {
            //Console.WriteLine("=== 간단한 델리게이트와 이벤트 예제 ===");

            ////1. 델리게이트 사용해보기
            //Console.WriteLine("델리게이트1");

            ////델리게이트 변수 선언 및 메서드 연결
            ////DisplayMessage 메서드를 messageHandler 변수에 할당
            //MessageHandler messageHandler = DisplayMessage;
            ////델리게이트 호출 - 연결된 메서드가 실행됨
            //messageHandler("안녕하세요");

            ////델리게이트에 다른 메서드 추가 (멀티캐스트 델리게이트)
            //// += 연결자로 메서드 추가
            //messageHandler += DisplayUpperMessage;

            ////여러 메서드가 연결된 델리게이트 호출
            ////등록된 모든 메서드가 순서대로 호출됨
            //Console.WriteLine("여러 메서드 호출: ");
            //messageHandler("Hello");


            ////캐릭터 생성
            //Character hero = new Character("용사", 100);
            ////이벤트 구독 +=
            ////이벤트가 발생했을때 실행될 메서드 등록
            //hero.OnDamaged += Hero_OnDamaged;
            ////데미지 입히기
            ////TakeDamage 메서드 내에서 OnDamaged 이벤트가 발생함
            //hero.TakeDamage(30);
            ////이벤트 구독 취소 -=
            ////더이상 이벤트 발생시 메서드가 호출되지 않음
            //hero.OnDamaged -= Hero_OnDamaged;
            //Console.WriteLine("이벤트 구독 취소");
            //hero.TakeDamage(20); //이벤트 발생함수는 실행하지만 내용은 실행 안함


            //Action은 매개변수가 없고 반환값이 없는 메서드를 참조
            //메서드 이름을 변수에 저장한다고 생각하면 쉬움
            Action sayHello = SayHello;
            sayHello += ShowNotification;
            sayHello?.Invoke();

            Action<string> h = null;
            h += HelloWorld;
            h?.Invoke("이게 액션이다.");

            Action noti = null;
            noti += () => Console.WriteLine("인자없는 액션이다.");
            noti?.Invoke();

            Action<int> square = number => Console.WriteLine(number * number);
            square(5);
        }
    }
}
