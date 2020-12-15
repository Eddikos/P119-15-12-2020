using System;
using System.Text.RegularExpressions;

namespace _15122020
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int num1 = int.Parse(Console.ReadLine());
                //int num2 = int.Parse(Console.ReadLine());

                //int result = num1 / num2;

                //Console.WriteLine("{0} divided by {1} equals {2}", num1, num2, result);

                //Book pushkin = new Book();
                //pushkin.Name = "Dub";
                // Console.WriteLine(pushkin.FullName());

                //Book harryPotter = new Book();
                //PrintBookName(null);

                // Method1();

                // Regular Expressions
                string elvset = "dfghjklò, a89230y 8rpsdfh asfdh 8934y sjdfh sвапролорф фгыв гф";
                Regex regex = new Regex("[A-Za-z0-9]");

                MatchCollection list = regex.Matches(elvset);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                throw;
                Console.WriteLine("An error occurred 1: " + ex.Message);
            }
        }

        static void Method1()
        { 
            try
            {
                Method2();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        static void Method2()
        {
            string str = null;

            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Problem bash verdi");
            }
        }

        public static void PrintBookName(Book book)
        {
            if (book == null) throw new Exception("Bosh object geldi");

            if (string.IsNullOrEmpty(book.Name)) throw new Exception("Mene bosh kitab gonderme");

            Console.WriteLine(book.Name);
        }
    }

    public class Book
    { 
        public string Name { get; set; }
        public int Volume { get; set; }
        public Page Page { get; set; }


        public string FullName()
        {
            return Name + Volume.ToString(); //+ GetPageNumber();
        }

        public string GetPageNumber()
        {
            return Page.PageNumber.ToString();
        }

    }

    public class Page
    {
        public int PageNumber { get; set; }
    }
}
