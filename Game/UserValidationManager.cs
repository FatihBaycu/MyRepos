using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            int YearNow = Convert.ToInt32(DateTime.Now.Year.ToString());

            if (gamer.adi != null && gamer.soyadi != null && gamer.tcNo != null && gamer.dogumYili == YearNow)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
