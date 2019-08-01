using System.Collections.Generic;

namespace asg3
{
    public class NewsObj
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averagerate;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float Averagerate
        {
            get => averagerate;
            set => averagerate = value;
        }


        public NewsObj(int id, string title, string publishDate, string author, string content, float averagerate)
        {
            this.Id = id;
            this.Title = title;
            this.PublishDate = publishDate;
            this.Author = author;
            this.Content = content;
            this.Averagerate = averagerate;
        }
    }
}