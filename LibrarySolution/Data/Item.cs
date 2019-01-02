using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibrarySolution
{
    public abstract class Item : INotifyPropertyChanged
    {
        public int id { get; set; }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                onPropertyChanged();
            }
        }
        public int authorId { get; set; }
        public int creationYear { get; set; }
        public string description { get; set; }
        public string language { get; set; }

        public Item(string title, int authorId, int creationYear, string language)
        {
            this.title = title;
            this.authorId = authorId;
            this.creationYear = creationYear;
            this.language = language;
        }

    public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

    }
}