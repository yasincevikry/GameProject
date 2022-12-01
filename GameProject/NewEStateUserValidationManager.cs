using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }

        void IGamerValidationService.Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
