using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Create videos and comments added
        Video video1 = new Video("Fierce & Flawless", "Jeffree Star", 120);
        video1.AddComment("David", "Great video!");
        video1.AddComment("Rose", "Nice content!");
        video1.AddComment("Mary", "I learned a lot!");
        video1.AddComment("Quinn", "Keep it up!");

        Video video2 = new Video("Beauty by Design", "Jaclyn Hill", 180);
        video2.AddComment("Cris", "Interesting topic!");
        video2.AddComment("Power12", "Well explained!");
        video2.AddComment("Nicole", "Looking forward to more!");
        video2.AddComment("Roype12", "Amazing work!");

        Video video3 = new Video("The Beauty Beat", "James Charles", 150);
        video3.AddComment("Andywizz", "Very informative!");
        video3.AddComment("Rose", "I enjoyed this!");
        video3.AddComment("Cruz", "Thanks for sharing!");
        video3.AddComment("Jenipher", "Brilliant!");

        Video video4 = new Video("The Makeup Maven", "Huda Kattan", 200);
        video4.AddComment("Royz", "Impressive!");
        video4.AddComment("Zara", "I have a question.");
        video4.AddComment("Bishop", "Can you make more on this?");
        video4.AddComment("Nathan", "This helped me a lot!");

        // Create a list to store videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}