using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Livingston_Stephen
{
    class Player
    {
        public int Health { get; set; }// automatic properties that sets integer with getter and setter.

        public string GamerTag { get; } // sets string with getter.

        public Player(int healthparam, string nameParam)  // constructor that takes one integer and string parameter and assigns them to the respective property.
        {
            Health = healthparam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue) // method that checks if current players is equal to max players. If it is, it adds 'this' player to the queue. If not it prints "joining game"
        {
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this); 
            }
            else
            {
                Console.WriteLine("Joining Game"); 
                game.CurrentPlayers++;
            }
        }

        public override string ToString() // returns the gamertag.
        {
            return GamerTag;
        }
    }
}
