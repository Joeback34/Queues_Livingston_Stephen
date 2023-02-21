using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Livingston_Stephen
{
    class Game
    {
       public int MaxPlayers { get; } // sets public integer with a  getter.

       public int CurrentPlayers { get; set; } // sets public integer witha  getter and setter.

        public Game(int maxP, int currentP) // constructor that assigns parameters to maxPlayers and currentPlayers.
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer() // public method that decrease decrements the current player count by 1.
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue) // method that checks if the queue has players in it and if it does it adds 1 player. If queue does not have players it prints "no players in the queue"
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
