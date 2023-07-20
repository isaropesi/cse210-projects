using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture
        {
            Title = "Introduction to Programming",
            Description = "Learn the basics of programming",
            Date = new DateTime(2023, 7, 20),
            Time = "10:00 AM",
            Address = new Address { Street = "123 Main St", City = "New York", State = "NY", Country = "USA" },
            Speaker = "John Doe",
            Capacity = 50
        };

        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(lecture.GenerateShortDescription());

        Console.WriteLine();

        Reception reception = new Reception
        {
            Title = "Company Anniversary Party",
            Description = "Join us to celebrate our anniversary",
            Date = new DateTime(2023, 8, 15),
            Time = "7:00 PM",
            Address = new Address { Street = "456 Elm St", City = "London", State = "", Country = "UK" },
            RSVPEmail = "rsvp@example.com"
        };

        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(reception.GenerateShortDescription());

        Console.WriteLine();

        OutdoorGathering gathering = new OutdoorGathering
        {
            Title = "Summer BBQ",
            Description = "Enjoy a fun-filled BBQ event",
            Date = new DateTime(2023, 7, 30),
            Time = "12:00 PM",
            Address = new Address { Street = "789 Oak St", City = "Los Angeles", State = "CA", Country = "USA" },
            Weather = "Sunny"
        };

        Console.WriteLine(gathering.GenerateStandardDetails());
        Console.WriteLine(gathering.GenerateFullDetails());
        Console.WriteLine(gathering.GenerateShortDescription());

        Console.ReadLine();
    }
}