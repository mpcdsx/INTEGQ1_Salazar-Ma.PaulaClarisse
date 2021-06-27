using Kanban.DL;
using System;
using System.Collections.Generic;

namespace Kanban.BL
{
    public class ValidationOfUser
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("Paula","Salazar")
        };

        public void LogIn()
        {
            Task3 list = new Task3();
            bool successful = false;
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Successfully log-in!");
                    successful = true;
                    list.ListOfUsers();
                }
            }
            if (!successful)
            {
                Console.WriteLine("Account doesn't exist.");
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("Successfully registered!");

            LogIn();
            
        }
    }
}