
namespace TaskOOP
{
    class BorrowedBooks : LibrarySystem
    {
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }
        public BorrowedBooks(int itemId, Book bookDetails, string borrowerName, DateTime borrowedDate)
        {
            ItemId = itemId;
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }
        public int DurationOFBorrowedBooks()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }
    }
}
