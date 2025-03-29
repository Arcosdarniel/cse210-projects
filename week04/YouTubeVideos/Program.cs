using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Greatest Showman", "Stephen Fry", 100);
        video1.AddComment("Stephen Fry", "Amazing performance!");
        video1.AddComment("Stephen Fry", "The choreography was stunning.");
        video1.AddComment("Stephen Fry", "Incredible visuals.");
        video1.GetDisplayVideo();
        video1.GetNumberOfComments();

        Video video2 = new Video("Echoes of Time", "Jane Holloway", 245);
        video2.AddComment("Jane Holloway", "The storyline was very engaging.");
        video2.AddComment("Jane Holloway", "A thrilling experience from start to finish.");
        video2.GetDisplayVideo();
        video2.GetNumberOfComments();

        Video video3 = new Video("Beyond the Horizon", "Mark Stevenson", 312);
        video3.AddComment("Mark Stevenson", "Visually captivating and thought-provoking.");
        video3.AddComment("Mark Stevenson", "I love how it explores the future of humanity.");
        video3.AddComment("Mark Stevenson", "The ending left me speechless.");
        video3.GetDisplayVideo();
        video3.GetNumberOfComments();

        Video video4 = new Video("The Lost Symphony", "Emily Carter", 180);
        video4.AddComment("Emily Carter", "The music was absolutely mesmerizing.");
        video4.GetDisplayVideo();
        video4.GetNumberOfComments();
    }
}


