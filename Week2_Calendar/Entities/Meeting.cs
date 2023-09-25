using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2_Calendar.Abstract;
using Week_2_Calendar.Common;

namespace Week_2_Calendar.Entities
{

    class Meeting : Event, INotification
    {

        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }


}
