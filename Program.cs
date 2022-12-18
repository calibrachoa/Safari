using System;

namespace Safari_Game
{
    /// <summary>
    /// Class <c>Program</c> is the entry point to the programme.
    /// <para>
    /// It introduces user to the theme, displays the menu and allows the user to choose between listing the
    /// animals or choosing a random one.
    /// </para>
    /// <para>
    /// Programme made with heart by Juan and adapted by Justine.
    /// </para>
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Method <c>Main</c> is the entry point to the programme.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Africa!\nIn this programme, you can meet animals on a safari.\n");
            WaitForUserInput();
            Safari safari = new Safari();
            Menu(safari);
        }

        /// <summary>
        /// Method <c>Menu</c> will display the menu prompt and dispatch the right action according to the
        /// user answer.
        /// <param name="safari">the safari visited by the user.</param>
        /// </summary>
        private static void Menu(Safari safari)
        {
            MenuPrompt();
            int userAnswer;
            string userLine = Console.ReadLine();
            while (!int.TryParse(userLine, out userAnswer) || userAnswer < 1 || userAnswer > 3)
            {
                MenuPrompt();
                Console.WriteLine("Please type <1> or <2> to continue, or <3> to exit!\n");
                userLine = Console.ReadLine();
            }

            switch (userAnswer)
            {
                case 1:
                    Console.Clear();
                    safari.ChooseRandomAnimal();
                    WaitForUserInput();
                    Menu(safari);
                    break;
                case 2:
                    Console.Clear();
                    safari.ListVisibleAnimals();
                    WaitForUserInput();
                    Menu(safari);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method <c>WaitForUserInput</c> will display a prompt to type anything and wait for the answer.
        /// </summary>
        private static void WaitForUserInput()
        {
            Console.WriteLine("Press <enter> to continue.\n");
            Console.ReadLine();
        }

        /// <summary>
        /// Method <c>MenuPrompt</c> contains the text prompting the user to choose what they want to do.
        /// </summary>
        private static void MenuPrompt()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do on this safari?" + 
                "\nPress <1> and then <enter> if you want to meet a random animal." +
                "\nPress <2> and then <enter> if you want the list of animals you could meet." +
                "\nPress <3> and then <enter> if you want to exit the programme.\n"
            );
        }
    }
}
