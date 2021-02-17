using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IGameService
    {
        void NewGamer(Gamer gamer);
        void UpdateGamer(Gamer gamer);
        void DeleteGamer(Gamer gamer);
    }
}
