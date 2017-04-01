using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanApplication
{
    class Draw
    {
        //Create the game title HANGMAN
        public void DrawGameTitle()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            Console.Write("                                                {0}",(char)72);
            Console.Write(                                                      (char)65);
            Console.Write(                                                      (char)78);
            Console.Write(                                                      (char)71);
            Console.Write(                                                      (char)77);
            Console.Write(                                                      (char)65);
            Console.Write(                                                      (char)78);
        }

        //Draws the gallows without the body
        public void DrawGallow()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");
        }

        //Draws the head after the first incorrect answer
        public void DrawHead()
        { 
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");
        }

        //Draws the left arm after second incorrect answer
        public void DrawLeftArm()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |              \\     ");
            Console.WriteLine("                                          |               \\    ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");
        }

        //Draws the torso after the third incorrect answer
        public void DrawTorso()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |              \\ |   ");
            Console.WriteLine("                                          |               \\|   ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");
        }

        //Draws the right arm after the fourth incorrect answer
        public void DrawRightArm()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |              \\ | / ");
            Console.WriteLine("                                          |               \\|/  ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");
        }

        //Draws the left leg after the fifth incorrect answer
        public void DrawLeftLeg()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |              \\ | / ");
            Console.WriteLine("                                          |               \\|/  ");
            Console.WriteLine("                                          |               /     ");
            Console.WriteLine("                                          |              /      ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |___________________| ");

        }

        //Draws the whole person game over
        public void DrawPerson()
        {
            Console.WriteLine();
            Console.WriteLine("                                          _________________     ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |                0    ");
            Console.WriteLine("                                          |              \\ | / ");
            Console.WriteLine("                                          |               \\|/  ");
            Console.WriteLine("                                          |                |    ");
            Console.WriteLine("                                          |               / \\  ");
            Console.WriteLine("                                          |              /   \\ ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |                     ");
            Console.WriteLine("                                          |____________________ ");
            Console.WriteLine("                                          |                   | ");
            Console.WriteLine("                                          |     GAME OVER     | ");
            Console.WriteLine("                                          |___________________| ");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

            

