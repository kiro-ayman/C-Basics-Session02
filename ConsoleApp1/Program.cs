namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Book b1 = new Book();
            //object obj = b1;

            //Console.WriteLine(obj);
            //Console.WriteLine(b1.title);
            //Console.WriteLine(b1.pages);
            #endregion

            #region question 2
            //Book b2 = new Book();
            //Console.WriteLine(b2.Equals(b2));
            //Console.WriteLine(b2.GetHashCode());
            //Console.WriteLine(b2.GetType());
            //Console.WriteLine(b2.ToString());
            #endregion

            #region question 3
            //compile time error 
            //int pages = 464;
            #endregion

            #region question 4
            int x = 10;
            int y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("done");
            }

            #endregion


        }
    }
    }
