using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Managements
{
    class GameManager:IGameService
    {
        public void NewGame(Game game)
        {
            Console.WriteLine(game.adi+" adli "+game.id+" id'li "+ game.price+" fiyatlı oyun eklenmiştir.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.adi + " adli " + game.id + " id'li " + game.price + " fiyatlı oyun güncellenmiştir.");

        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.adi + " adli " + game.id + " id'li " + game.price + " fiyatlı oyun silinmiştir.");

        }
    }
}
