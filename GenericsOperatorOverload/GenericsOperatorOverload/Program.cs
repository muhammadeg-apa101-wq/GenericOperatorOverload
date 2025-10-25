using GenericsOperatorOverload.Models;

namespace GenericsOperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region intList
            //DataList<int> intList = new();
            //intList.Add(10);
            //intList.Add(20);
            //intList.GetAll();
            #endregion

            #region stringList
            //DataList<string> stringList = new();
            //stringList.Add("Hello");
            //stringList.Add("World");
            //stringList.Add("siuu");
            //stringList.GetAll();
            #endregion

            #region bookList
            DataList<BookList> bookList = new();

            bookList.Add(new BookList() { Id = 1, Author = "baloglan dostoyevski", BookName = "salam sagol kitabi" });
            bookList.Add(new BookList() { Id = 2, Author = "eflatun kerimov", BookName = "cidir duzu" });
            bookList.GetAll();
            #endregion

            #region Operator overloading
            Humans human = new(15);
            Animals animal = new(10);

            if (animal > human)
            {
                Console.WriteLine("Animal sayi daha coxdur");
            }
            else
            {
                Console.WriteLine("Human sayi daha coxdur");

            }
            #endregion


        }
    }
}
