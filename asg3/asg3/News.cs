using System;
using System.Collections.Generic;
using System.Linq;

namespace asg3
{
    public class News : INews
    {
        public List<NewsObj> NewsList = new List<NewsObj>();
        private List<int> rateList;
        public int Average;
        public float averagerate;
        public void AddNews()
        {
            rateList = new List<int>();
            int id;
            int rating;
            string title;
            string publishDate;
            string author;
            string content;
            Console.WriteLine("Enter title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter publish date:");
            publishDate = Console.ReadLine();
            Console.WriteLine("Enter author:");
            author = Console.ReadLine();
            Console.WriteLine("Enter content:");
            content = Console.ReadLine();
            id = NewsList.Count + 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Rate("+(i+1)+"/3):(.../5)");
                rating = Convert.ToInt32(Console.ReadLine());
                rateList.Add(rating);
            }
            Calculate();
            NewsList.Add(new NewsObj(id, title, publishDate, author, content, averagerate));
        }
        public void Display()
        {
            foreach (NewsObj n in NewsList)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Title: "+n.Title+"|  Publish date: "+ n.PublishDate);
                Console.WriteLine("--Author: " + n.Author);
                Console.WriteLine("___Content___________________________________");
                Console.WriteLine(n.Content);
                Console.WriteLine("_____________________________________________");
                if (Average == 1)
                {
                    Console.WriteLine("Average rate: "+ n.Averagerate +"/5.");
                }
                Console.WriteLine("---------------------------------------------");   
            }
        }

        public void Calculate()
        {
            int rateSum = 0;
            foreach (int i in rateList)
            {
                rateSum += i;
            }

            averagerate = rateSum / 3;
        }
    }
}