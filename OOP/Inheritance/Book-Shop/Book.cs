using System;
using System.Text;

namespace Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title 
        {
            get { return this.title; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title cannot be null or empty!");
                }
                this.title = value;
            }
        }
        public string Author
        {
            get { return this.author; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author cannot be null or empty!");
                }
                this.author = value;
            }
        }
        public virtual decimal Price 
        {
            get { return this.price; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("-Type: {0} {1}", this.GetType().Name, Environment.NewLine);
            result.AppendFormat("-Title: {0} {1}", this.Title, Environment.NewLine);
            result.AppendFormat("-Author: {0} {1}", this.Author, Environment.NewLine);
            result.AppendFormat("-Price: {0} {1}", this.Price, Environment.NewLine);

            return result.ToString();
        }
    }
}
