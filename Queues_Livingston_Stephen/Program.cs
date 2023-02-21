using System;
using System.Collections.Generic;
namespace Queues_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>(); // new game object that is set to 50 max players and 49 current players. 

            Player p1 = new Player(100, "Joeback"); // queue of player objects each with 100 health and unque tag. 
            Player p2 = new Player(100, "RevolverAlastor");
            Player p3 = new Player(100, "SlickNick");
            Player p4 = new Player(100, "Corn Chex");

            p1.JoinGame(myGame, waitingToJoinQ); // calls the JoinGame on all 4 player objects passing the game and queue as arguments.
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("Players in the Q:"); // prints to the console "players in the Q".
            
            foreach(Player player in waitingToJoinQ) // loops through the queue and prints all the players on a new line
            {
                Console.WriteLine(player);
            }

            myGame.KickPlayer(); // calls the KickPlayer method.
            myGame.CheckQueue(waitingToJoinQ); // calls the CheckQueue method .
            
            Console.WriteLine("\nPlayers in the Q:"); // prints "Plays in the Q".  
            foreach (Player player in waitingToJoinQ)   // loops through the queue and prints all the players on a new line..
            {
                Console.WriteLine(player);
            }
        }
    }   
}
