using Kanban.DL;
using System;
using System.Collections.Generic;

namespace Kanban.BL
{
    public class Task2
    {
        public List<Task> ActivityInfo = new List<Task>()
        {
            new Task ("INTEG","1", new DateTime(2021,6,26)),
        };

        public void ViewActivity()
        {
            foreach (Task activity in ActivityInfo)
            {
                Console.WriteLine("Subject: {0} \n Activity Number: {1} \n Date: {2}", activity.Subject, activity.Number, activity.Date);
            }
        }
        public void AddActivity()
        {
            foreach (Task product in ActivityInfo)
            {
                Console.WriteLine("Subject: {0} \n Activity Number: {1} \n Date: {2}", product.Subject, product.Number, product.Date);
            }

            Console.WriteLine("Enter the subject you need to do: ");
            string addActivity = Console.ReadLine();
            Console.WriteLine("Enter activity number: ");
            string addActivityNumber = Console.ReadLine();
            DateTime addDate = DateTime.Now;


            ActivityInfo.Add(new Task(addActivity, addActivityNumber, addDate));
            Console.WriteLine("Subject: {0} \n Activity Number: {1} \n Date: {2} \n Successfully added!", addActivity, addActivityNumber, addDate);

            foreach (Task activity in ActivityInfo)
            {
                Console.WriteLine("Subject: {0} \n Activity Number: {1} \n Date: {2}", activity.Subject, activity.Number, activity.Date);
            }
        }
        public void RemoveActivity()
        {
            Console.WriteLine("Enter Index Position:");
            int indexPosition = int.Parse(Console.ReadLine());

            ActivityInfo.RemoveAt(indexPosition);

            foreach (Task activity in ActivityInfo)
            {
                Console.WriteLine("Subject: {0} \n Activity Number: {1} \n Date: {2}", activity.Subject, activity.Number, activity.Date);
            }
        }
    }
}