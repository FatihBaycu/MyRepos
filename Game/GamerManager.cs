using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerManager : IGameService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void NewGamer(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer Created!");

            }
            else
            {
                Console.WriteLine("Gamer Not Created!!!");

            }
        }

        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated!");
        }

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted!");
        }
    }
}
