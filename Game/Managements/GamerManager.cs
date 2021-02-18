using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerManager:IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.adi+ " "+gamer.soyadi+" Gamer Created!");

            }
            else
            {
                Console.WriteLine(gamer.adi + " " + gamer.soyadi + " Gamer Not Created!");

            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + " Gamer Updated!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.adi + " " + gamer.soyadi + " Gamer Deleted!");
        }
    }
}
