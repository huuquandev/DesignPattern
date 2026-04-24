using System;
using ObserverDesignPattern.Base;

namespace ObserverDesignPattern
{
    public class VideoData : Subject
    {
        #region Private Properties
        private string _title;
        private string _description;
        private string _fileName;
        #endregion  

        #region GetSetProperties
        public string getTitle()
        {
            return _title;
        }
        public void setTitle(string title)
        {
            _title = title;
            VideoDataChanged();
        }
        public string getDescription()
        {
            return _description;
        }
        public void setDescription(string description)
        {
            _description = description;
            VideoDataChanged();
        }
        public string getFileName()
        {
            return _fileName;
        }
        public void setFileName(string fileName)
        {
            _fileName = fileName;
            VideoDataChanged();
        }
        #endregion

        private void VideoDataChanged()
        {
            NotifyObservers(this, null);
        }
    }
}