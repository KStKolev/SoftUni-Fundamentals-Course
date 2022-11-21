namespace Articles
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int numberOfTheLoop = int.Parse(Console.ReadLine());
            PrintArticle(inputArray, numberOfTheLoop);
        }

        private static void PrintArticle(string[] inputArray, int numberOfTheLoop)
        {
            string title = inputArray[0];
            string content = inputArray[1];
            string author = inputArray[2];
            string inputText = string.Empty;
            for (int i = 0; i < numberOfTheLoop; i++)
            {
                inputText = Console.ReadLine();
                string[] textArray = inputText.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = textArray[0];
                string newValue = textArray[1];
                content = Article.NewContent(content, command, newValue);
                author = Article.NewAuthor(author, command, newValue);
                title = Article.NewTitle(title, command, newValue);
            }
            Article article = new Article(title, content, author);
            Console.WriteLine(article);
            Console.Read();
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

        public static string NewContent(string content, string command, string newValue)
        {
            if (command.Equals("Edit"))
            {
                content = newValue;
            }

            return content;
        }
        public static string NewAuthor(string author, string command, string newValue)
        {
            if (command.Equals("ChangeAuthor"))
            {
                author = newValue;
            }

            return author;
        }
        public static string NewTitle(string title, string command, string newValue)
        {
            if (command.Equals("Rename"))
            {
                title = newValue;
            }

            return title;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author} ";
        }
    }
}
