using System;

namespace CSharp

{
    class Program
    {
        enum ClassType 
        {
            None =0,
            Knight = 1,
            Archer =2,
            Mage = 3
        }
        
        static ClassType ChooseClass()
        {
            ClassType choice = ClassType.None;

            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }
        static void CreatePlayer(ClassType choice, out int hp, out int attack)
        {
            hp = 0;
            attack = 0;
            switch (choice)
            {              
                case ClassType.Knight:
                    hp = 100;
                    attack = 10;
                    break;
                case ClassType.Archer:
                    hp = 75;
                    attack = 12;
                    break;
                case ClassType.Mage:
                    hp = 50;
                    attack = 15;
                    break;            
            }
            Console.WriteLine($"플레이어의 체력 : {hp} ");
            Console.WriteLine($"플레이어의 공격력 : {attack}");
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    //캐릭터 생성
                    int hp;
                    int attack;
                    CreatePlayer(choice, out hp, out attack);
                    //필드로 가서 몬스터랑 싸움
                    break;
                }
                    
            }

            


        }
    }
}
