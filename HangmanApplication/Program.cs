using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Game g = new Game();

            g.PlayGame();
            
            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }
    }
}
