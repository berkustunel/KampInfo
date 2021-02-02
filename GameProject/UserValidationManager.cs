using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "Berk" 
                && gamer.LastName == "Üstünel" && gamer.IdentityNumber == 1234567890)
            {
                return true;
            } else
            {
                return false;
            }
            
            
        }
    }
}
