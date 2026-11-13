namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            Book b1 = new Book();
            object obj = b1;

            Console.WriteLine(obj);
            Console.WriteLine(b1.title);
            Console.WriteLine(b1.pages);
            #endregion        
        }
        }
    }
