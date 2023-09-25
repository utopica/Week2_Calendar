using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2_Calendar.Common;
using Week_2_Calendar.Abstract;

namespace Week_2_Calendar.Entities
{
    class Todo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this to-do: {Title}");
        }

    }
}
