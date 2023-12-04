using System;

class Program
{
    static void Main()
    {
        // instances of each event type
        Address eventAddress = new Address("2501 California St", "San Francisco", "CA", "94115");
        Lecture lectureEvent = new Lecture("Beauty Talk", "Exciting beauty discussions", DateTime.Now, new TimeSpan(14, 0, 0), eventAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Beauty Mixer", "Meet and greet", DateTime.Now, new TimeSpan(18, 30, 0), eventAddress, "info@beautypara.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Beauty", "Casual outdoor gathering", DateTime.Now, new TimeSpan(17, 0, 0), eventAddress, "Sunny with a chance of clouds");

        //  marketing messages for each event
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n--------------------------------------------\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n--------------------------------------------\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
