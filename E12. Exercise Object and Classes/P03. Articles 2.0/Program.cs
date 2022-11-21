namespace Articles2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfTheLoop = int.Parse(Console.ReadLine());
            PrintArticle(numberOfTheLoop);
        }

        private static void PrintArticle(int numberOfTheLoop)
        {
            List<Article> articles = new List<Article>();
            string inputText = string.Empty;
            for (int i = 0; i < numberOfTheLoop; i++)
            {
                inputText = AddNewArticles(articles);
            }
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        private static string AddNewArticles(List<Article> articles)
        {
            string inputText = Console.ReadLine();
            string[] textArray = inputText.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = textArray[0];
            string content = textArray[1];
            string author = textArray[2];
            Article article = new Article(title, content, author);
            articles.Add(article);
            return inputText;
        }
    }
    public class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author} ";
        }
    }
}

