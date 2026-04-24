using ObserverDesignPattern.Base;

namespace ObserverDesignPattern.Notifier
{
    public class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            this._subject = subject;
            this._subject.AttachObserver(this);
        }
        public override void Notify(Subject subject, object arg)
        {
            if(subject is VideoData videoData)
            {
                Console.WriteLine(
                    string.Format($"Notify all subcribers via PHONE with new data" + 
                                "\n\tName: {0}" +
                                "\n\tDescription: {1}" +
                                "\n\tFile name: {2}",
                                videoData.getTitle(), 
                                videoData.getDescription(), 
                                videoData.getFileName()
                                ));
            }
        }
    }
}