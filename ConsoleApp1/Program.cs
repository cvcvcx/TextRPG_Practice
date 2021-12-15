using System;

namespace CSharp

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1]기사");
                Console.WriteLine("[2]궁수");
                Console.WriteLine("[3]법사");

                string input = Console.ReadLine();

                if (input == "1" || input == "2" || input == "3")
                    break;
            }

            


        }
    }
}
