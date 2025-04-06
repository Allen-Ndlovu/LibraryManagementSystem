namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title, string author, bool isBorrowed)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = isBorrowed;
        }
    }
}
