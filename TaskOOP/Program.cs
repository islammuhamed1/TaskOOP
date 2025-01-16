namespace TaskOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book ISBN:");
            string isbn = Console.ReadLine();
            Book myBook = new Book(title, author, isbn);
            Console.WriteLine("Enter borrower name:");
            string borrowerName = Console.ReadLine();
            int DaysValidate;
            do
            {
                Console.WriteLine("Enter borrowed days ago (as a number):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out DaysValidate) && DaysValidate >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Integer Number , Ex 1,2,3,etc...");
                }
            } while (true);
            BorrowedBooks borrowedBook = new BorrowedBooks(1, myBook, borrowerName, DateTime.Now.AddDays(-DaysValidate));
            borrowedBook.CheckOut();
            Console.WriteLine($"The book '{borrowedBook.BookDetails.Title}' has been borrowed for {borrowedBook.DurationOFBorrowedBooks()} days.");
            borrowedBook.ReturnItem();
        
        }
    }
}
