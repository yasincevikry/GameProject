using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        public void Register(Gamer gamer)
        {
            Console.WriteLine("You were registered " + gamer.FirstName + " " + " Good Luck & Have Fun!");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Your account has been updated " + gamer.FirstName + " Keep playing! ");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + "Your account has been deleted! We will miss you :(");
        }
    }
}
