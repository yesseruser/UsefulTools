namespace UsefulTools
{
    public partial class Tools
    {
        public class Book
        {
            public int pages;
            public string title;
            public Author author;

            public Book(int pages, string title, Author author)
            {
                this.pages = pages;
                this.title = title;
                this.author = author;
            }
        }
    }
}
