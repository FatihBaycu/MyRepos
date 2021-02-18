using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IGameService
    {
        void NewGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
    }
}
