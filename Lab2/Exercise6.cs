using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("***************Library Item Details**********************");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine("**********************************************************");
        }
    }

    internal class Book : LibraryItem
    {
        public string ISBN { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int publicationYear, string isbn, string genre) : base(title, author, publicationYear)
        {
            ISBN = isbn;
            Genre = genre;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("***************Book Details****************************");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine("**********************************************************");
        }
    }

    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Frequency { get; set; }

        public Magazine(string title, string author, int publicationYear, int issueNumber, string frequency) : base(title, author, publicationYear)
        {
            IssueNumber = issueNumber;
            Frequency = frequency;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("***************Magazine Details****************************");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Issue Number: {IssueNumber}");
            Console.WriteLine($"Frequency: {Frequency}");
            Console.WriteLine("**********************************************************");
        }
    }
}
