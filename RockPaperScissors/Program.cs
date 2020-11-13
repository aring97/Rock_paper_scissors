using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int player=0;
            int computer=0;
            while(player<3 && computer<3){
            System.Console.WriteLine( "-----------------------------");
            System.Console.WriteLine($"Player: {player} | Computer: {computer}");
            System.Console.WriteLine( "-----------------------------");
            System.Console.WriteLine("What would you throw?");
            System.Console.WriteLine("1) Rock");
            System.Console.WriteLine("2) Paper");
            System.Console.WriteLine("3) Scissor");
            int playerResponse=Int32.Parse(Console.ReadLine());
            Random random=new Random();
            int computerResponse=random.Next(1,3);
            switch (computerResponse)
            {
                case 1:
                System.Console.WriteLine("Rock");
                break;
                case 2:
                System.Console.WriteLine("Paper");
                break;
                case 3:
                System.Console.WriteLine("Scissor");
                break;
            }
            if(playerResponse==1&&computerResponse==3 || playerResponse==2&&computerResponse==1 || playerResponse==3&&computerResponse==2){
                player++;
            }else if(computerResponse==1&&playerResponse==3 || computerResponse==2&&playerResponse==1 || computerResponse==3&&playerResponse==2){
                computer++;
            }
            }
            if(player==3){
                System.Console.WriteLine("YOU WIN");
            }else{
                System.Console.WriteLine("YOU LOSE");
            }

        }
    }
}
