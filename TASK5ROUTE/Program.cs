using static TASK5ROUTE.Books;

namespace TASK5ROUTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Book book1 = new Book();
            // Console.WriteLine(book1.password);
            // Error: inaccessible due to protection level
            Console.WriteLine("Task 1: private field - inaccessible outside class");
            Console.WriteLine();
            #endregion
        }
    }
}
