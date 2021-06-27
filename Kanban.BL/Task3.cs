using System;

namespace Kanban.BL
{
    public class Task3
    { 
    public void ListOfUsers()
    {
        Task2 productServices = new Task2();

    START:
        Console.WriteLine("(1) View your Task.");
        Console.WriteLine("(2) Add task.");
        Console.WriteLine("(3) Remove/Finish Task.");
        Console.WriteLine("(4) Close App      ");
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                productServices.ViewActivity();
                goto START;
            case 2:
                productServices.AddActivity();
                goto START;
            case 3:
                productServices.RemoveActivity();
                goto START;

            default:
                break;
        }

    }
}
}