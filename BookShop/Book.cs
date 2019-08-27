namespace BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title
        {
            get => this.title;
            protected set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get => this.author;
            protected set
            {
                var authorNames = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (authorNames.Length > 1)
                {
                    if (char.IsDigit(authorNames[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;
            protected set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid");
                }
                this.price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;

        }
    }
}
