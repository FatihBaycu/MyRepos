using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
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
                Console.WriteLine("Kayıt oldu.");

            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Başarısız.");
            }
        }

      
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }
    }
}
