class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Logan", "UT", "USA");
        Address address2 = new Address("456 Center St", "Provo", "UT", "USA");
        Address address3 = new Address("789 Park Ave", "Salt Lake City", "UT", "USA");

        Event lecture = new Lecture("Tech Talk", "AI Future", "April 10", "10:00 AM", address1, "John Smith", 100);
        Event reception = new Reception("Wedding Reception", "Celebrate!", "May 5", "6:00 PM", address2, "rsvp@email.com");
        Event outdoor = new Outdoor("Picnic", "Family gathering", "June 1", "12:00 PM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("----- STANDARD -----");
            Console.WriteLine($"{e.GetStandardDetails()}\n");

            Console.WriteLine("----- FULL -----");
            Console.WriteLine($"{e.GetFullDetails()}\n");

            Console.WriteLine("----- SHORT -----");
            Console.WriteLine($"{e.GetShortDetails()}\n");

            Console.WriteLine("-------------------------\n");
        }
    }
}