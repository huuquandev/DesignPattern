using System;
using ObserverDesignPattern.Base;
using ObserverDesignPattern.Notifier;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            var emailNotifier = new EmailNotifier(videoData);
            var phoneNotifier = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.setTitle("Observer Design Pattern");

            videoData.DetachObserver(youtubeNotifier);
            Console.WriteLine("==============================================================");
            videoData.setDescription("Observer Design Pattern edit runtime test");

            _ = new FacebookNotifier(videoData);
            Console.WriteLine("==============================================================");
            videoData.setFileName("Observer Design Pattern add new notifier");
        }
    }
}
