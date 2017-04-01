using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HangmanApplication
{
    class Game
    {
        public bool playAgain = true;
        Draw draw = new Draw();
        Random rnd = new Random();
        public int numOfWrongGuesses = 6;
        List<char> guessed = new List<char>();
        char letter;
        string[] words;
        int count;

        //Welcome the user / display hidden word / display gallows
        public void PlayGame()
        {
            int random = rnd.Next(1, 12);

            //load file
            LoadFile();

           // int LengthOfArray = words.Length;
            char[] letters = words[random].ToCharArray();
            count = words[random].Length;

            Console.WriteLine("Welcome to Hangman!");
            
            //While loop to keep game running if use wants to play again
            while (playAgain == true)
            {

                Console.WriteLine();
                Console.WriteLine("Number of incorrect guesses remaining : {0}", numOfWrongGuesses);
                Console.WriteLine("Guessed Letters : {0}", GetGuessedLetters());
                Console.WriteLine();
                Console.WriteLine();

                foreach (var tmp in letters)
                {   
                    if (guessed.Contains(tmp))
                    {
                        Console.Write(tmp);
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                }//End foreach (var tmp in letters)

                //Call the DrawGraphic() 
                DrawGraphic(numOfWrongGuesses);

                //Call SetGuessedLetters()
                SetGuessedLetters();
                
                if (words[random].Contains(this.letter))
                {
                    Console.WriteLine("Good guess : {0}", letter);
                    //guessed.Add(letter);

                    count--;
                    if (count == 0)
                    {
                        Console.WriteLine("Congratulations YOU WIN !!!!!! ");
                        PlayAgain();
                    }
                }
                else
                {
                    Console.WriteLine("You guessed wrong!");
                    numOfWrongGuesses --; 
                }
            }
        }



        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Enter 'Y' for 'Yes' or 'N' for 'No'");

            try
            {
                string playAgainAnswer = Console.ReadLine();

                if (playAgainAnswer.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                {
                   new Game().PlayGame();
                }
                else
                {
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }//End PlayAgain()



        public void DrawGraphic(int numberOFAttemptsLeft)
        {
            //Case statement to select correct draw method
            switch (numOfWrongGuesses)
            {
                case 6:
                    draw.DrawGallow();
                    break;

                case 5:
                    draw.DrawHead();
                    break;

                case 4:
                    draw.DrawLeftArm();
                    break;

                case 3:
                    draw.DrawTorso();
                    break;

                case 2:
                    draw.DrawRightArm();
                    break;

                case 1:
                    draw.DrawLeftLeg();
                    break;

                case 0:
                    draw.DrawPerson();
                    Console.WriteLine("Sorry you lost ");
                    PlayAgain();
                    break;
            }
        }//End DrawGraphic()



        public void SetGuessedLetters()
        {
            try
            {
                Console.WriteLine("Guess a letter ");
                this.letter = char.Parse(Console.ReadLine());
                if (string.IsNullOrEmpty(letter.ToString()))
                {
                    Console.WriteLine("Please select a letter");
                }
                guessed.Add(letter);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }//End SetGuessedLetters()


        public string GetGuessedLetters()
        {
            string s = "";
            foreach (char t in guessed)
            {

                s += t.ToString();
            }
            return s;
        }//End GetGuessedLetter()

        public void LoadFile()
        {

            //Check that file exists and loads file to string array
            try
            {
                if (System.IO.File.Exists(@"HangmanList.txt"))
                {
                    words = System.IO.File.ReadAllLines(@"HangmanList.txt");
                }
                else
                {
                    Console.WriteLine("File does not exist, select another file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
