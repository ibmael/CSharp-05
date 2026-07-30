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
            Console.WriteLine("Task 1: private field Inaccessible outside class");
            Console.WriteLine();
            #endregion
            #region Task 2
            Book book2 = new Book();
            Console.WriteLine($"Task 2: {book2.copiesInStock}");
            Console.WriteLine();
            #endregion
            #region Task 3
            Book book3 = new Book();
            book3.Title = "C# Programming";
            Console.WriteLine($"Task 3: {book3.Title}");
            Console.WriteLine();
            #endregion
            #region Task 4
            Book book4 = new Book();
            book4.Genre = Genre.Science;
            Console.WriteLine($"Task 4: {book4.Genre}");
            Console.WriteLine();
            #endregion
            #region Task 5
            Console.WriteLine($"Task 5 - Fiction: {(int)Genre.Fiction}");
            Console.WriteLine($"Task 5 - NonFiction: {(int)Genre.NonFiction}");
            Console.WriteLine($"Task 5 - Science: {(int)Genre.Science}");
            Console.WriteLine();
            #endregion
            #region Task 6
            int genreNumber = 1;
            Genre genre6 = (Genre)genreNumber;
            Console.WriteLine($"Task 6: {genre6}");
            Console.WriteLine();
            #endregion
            #region Task 7
            Genre genre7 = Genre.Fiction;
            string genreString = genre7.ToString();
            Console.WriteLine($"Task 7: {genreString}");
            Console.WriteLine();
            #endregion
            #region Task 8
            string genreText8 = "Science";
            Genre genre8 = (Genre)Enum.Parse(typeof(Genre), genreText8);
            Console.WriteLine($"Task 8: {genre8}");
            Console.WriteLine();
            #endregion
        }
    }
}
