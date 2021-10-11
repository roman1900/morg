using System;
using System.IO;

namespace morg
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Meeting m = new Meeting();
            Committee c;
            m.Attendees.Add(new Person(){First_Name="Matt",Last_Name="Marschall"});
            Console.WriteLine(m.Attendees[0].Initials);
            if (File.Exists(@".\committee.conf"))
            {
                c = new Committee(@".\committee.conf");
            }
            else
            {
                Console.WriteLine("Unable to determine committee. Exiting.");
            }
        }
    }
}
