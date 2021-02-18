using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidatonManager());
            gamerManager.Add(new Gamer{id = 1,birthYear = 1985, firstName = "Engin", identityNumber = 12345678921, lastName = "Demiroğ" });
            Console.ReadKey();
        }
    }
}
