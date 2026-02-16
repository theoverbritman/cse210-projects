using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Center St", "Austin", "TX", "USA");
        Address a2 = new Address("50 Park Ave", "New York", "NY", "USA");
        Address a3 = new Address("88 Lake Rd", "Denver", "CO", "USA");

        Event lecture = new Lecture("Tech Talk", "Future of AI", "March 5", "6:00 PM", a1, "Dr. Smith", 100);
        Event reception = new Reception("Company Party", "Annual celebration", "April 10", "7:00 PM", a2, "rsvp@company.com");
        Event outdoor = new OutdoorGathering("Community Picnic", "Food and games", "May 20", "12:00 PM", a3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n-------------------------\n");
        }
    }
}
