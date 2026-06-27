using System;
using System.Collections.Generic;
using System.Text;

namespace Cybot
{
    internal class Class1
    {
       public string Title {get; set;}

        public string Description { get; set; }
        public  DateTime?  ReminderDate{ get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            string reminder = ReminderDate.HasValue ? $" (Reminder: {ReminderDate.Value.ToString()})" : "" ;
            string status = IsCompleted ? " [Completed]" : "";
            return "${Title} - {Description}{reminder}{status}"; 
        }
    }
}
