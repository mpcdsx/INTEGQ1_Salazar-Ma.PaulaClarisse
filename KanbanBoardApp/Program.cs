using Kanban.BL;
using System;

namespace KanbanBoardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationOfUser user = new ValidationOfUser();

            Console.WriteLine("Kanban Board App Log-In For Students\n");
            Console.WriteLine("Type (1) to Log-in");
            Console.WriteLine("Type (2) to Register");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {

            }

        }

    }
}