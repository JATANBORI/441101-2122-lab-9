using System;

namespace L9._5_RockPaperScissorsGame
{
    class Program
    {
        static int MenuSelection(string pPrompt, string[] pMenuOptions)
        {
            int optionSelected;

            Console.WriteLine(pPrompt);
           
            for (int i = 0; i < pMenuOptions.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + pMenuOptions[i] + ".");
            }

            optionSelected = int.Parse(Console.ReadLine());

            return optionSelected;

        }

        //Select a winner method

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("The Rock Paper Scissors Game.");
            Console.WriteLine("=============================");
            Console.WriteLine("");
            
            do
            {
                // Your main codes here


                
                if (response == "N" || response == "n")
                {
                    break;
                }
            } while (true);

        }
    }
}
