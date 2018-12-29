using System;

namespace LibrarySolution
{
    public abstract class Item
    {
        public int id { get; set; }
        public String title { get; set; }
        public int authorId { get; set; }
        public int creationYear { get; set; }
        public String description { get; set; }
        public String language { get; set; }

        public Item(String title, int author_id, int creationYear, String language)
        {
            this.title = title;
            this.authorId = authorId;
            this.creationYear = creationYear;
            this.language = language;
        }

    }
}