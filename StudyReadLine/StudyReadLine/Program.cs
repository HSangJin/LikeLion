using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로 부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");


            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요."); //변환된 값 사용
            //Console.WriteLine("내년에는 " +(age+1)+" 살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age + 1);


            Console.Write("스킬 피해량을 입력하세요 : ");
            float luinSkillDMG = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            float cardGaugeAmount = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("각성기 피해량을 입력하세요 : ");
            float awakeningDMG = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("최대마나를 입력하세요 : ");
            int maxMP = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            int combatMPHealAmount = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("비전투 중 마나 회복량을 입력하세요 : ");
            int noncombatMPHealAmount = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("이동속도를 입력하세요 : ");
            float speed = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("탈 것 속도를 입력하세요 : ");
            float vehicle_speed = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("운반 속도 : ");
            float conveyance_speed = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("스킬 재사용 대기시간 감소량을 입력하세요 : ");
            float skillCooldownReduce = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("활동\t\t∨");
            Console.WriteLine("루인 스킬 피해 : "+ luinSkillDMG+ "%");
            Console.WriteLine("카드 게이지 획득량 : "+cardGaugeAmount+ "%");
            Console.WriteLine("각성기 피해 : " + awakeningDMG + "%");
            Console.WriteLine("최대마나 : "+ maxMP);
            Console.WriteLine("전투 중 마나 회복량 : "+ combatMPHealAmount);
            Console.WriteLine("비전투 중 마나 회복량 : "+ noncombatMPHealAmount);
            Console.WriteLine("이동속도 : "+ speed + "%");
            Console.WriteLine("탈 것 속도 : "+ vehicle_speed + "%");
            Console.WriteLine("운반 속도 : "+ conveyance_speed + "%");
            Console.WriteLine("스킬 재사용 대기시간 감소 : " + skillCooldownReduce + "%");

        }
    }
}
