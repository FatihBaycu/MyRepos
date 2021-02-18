using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.birthYear == 1985 && gamer.firstName == "Engin" && gamer.lastName == "Demiroğ" && gamer.identityNumber == 12345678921)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
