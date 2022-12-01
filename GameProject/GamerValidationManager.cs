using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Yasin"
                && gamer.LastName == "Çevik" && gamer.IdentityNumber == 1905)
            {
                Console.WriteLine("Welcome Yasin");
            }
            else
            {
                Console.WriteLine("We can not find your account!");
            }

        }
    }
}
