namespace TaskOOP
{
    class LibrarySystem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; private set; } = true;

        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Item {ItemId} checked out.");
            }
            else
            {
                Console.WriteLine($"Item {ItemId} is already checked out.");
            }
        }

        public void ReturnItem()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Item {ItemId} has been returned.");
            }
            else
            {
                Console.WriteLine($"Item {ItemId} was not checked out.");
            }
        }
    }
}
