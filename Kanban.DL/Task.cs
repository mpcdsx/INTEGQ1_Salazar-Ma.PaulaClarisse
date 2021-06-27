using System;
using System.Text;

namespace Kanban.DL
{ 
    public class Task
{
        public string subjectName;
        private string number;
        private DateTime date;

        public Task(string subjectName, string number, DateTime date)
    {
        this.subjectName = subjectName;
        this.number = number;
        this.date = date;


    }


    public string Subject
    {
        get { return subjectName; }
        set { subjectName = value; }
    }

    public string Number
    {
        get { return number; }
        set { number = value; }
    }
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }


}
}