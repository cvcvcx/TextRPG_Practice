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

        struct Player
        {
            public int hp;
            public int attack;
            
        }
        
        enum MonsterType
        {
            None =0,
            Slime =1,
            Orc = 2,
            Skeleton = 3
        }
        struct Monster
        {
            public int hp;
            public int attack;
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
        static void CreatePlayer(ClassType choice, out Player player)
        {
            player.hp = 0;
            player.attack = 0;
            
            switch (choice)
            {              
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;            
            }
            Console.WriteLine($"플레이어의 체력 : {player.hp} ");
            Console.WriteLine($"플레이어의 공격력 : {player.attack}");
        }
        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    monster.hp = 20;
                    monster.attack = 2;
                    Console.WriteLine("슬라임이 나타났습니다!");
                    break;

                case (int)MonsterType.Orc:
                    monster.hp = 40;
                    monster.attack = 4;
                    Console.WriteLine("오크가 나타났습니다!");
                    break; 
                case (int)MonsterType.Skeleton:

                    monster.hp = 30;
                    monster.attack = 3;
                    Console.WriteLine("스켈레톤이 나타났습니다!");

                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }
        static void EnterField()
        {
            Console.WriteLine("필드에 접속했습니다.");
            //랜덤으로 1~3몬스터중 하나를 리스폰시킴
            Monster monster;
            CreateRandomMonster(out monster);
            Console.WriteLine("[1]전투모드로 돌입");
            Console.WriteLine("[2]일정 확률로 도망");
            //[1]전투모드로 돌입
            //[2]일정 확률로 도망
        }
        static void EnterGame()
        {
            while(true)
            {
                Console.WriteLine("게임에 접속했습니다.");
                Console.WriteLine("[1]필드로 간다");
                Console.WriteLine("[2]로비로 돌아간다");

                string input = Console.ReadLine();

                if(input == "1")
                {
                    EnterField();
                }
                else if(input == "2")
                {
                    break;
                }

            }
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    //캐릭터 생성
                    Player player;

                    CreatePlayer(choice, out player);

                    EnterGame();
                    //필드로 가서 몬스터랑 싸움                    
                }
                    
            }

            


        }
    }
}
