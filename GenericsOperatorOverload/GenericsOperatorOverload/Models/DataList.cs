using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsOperatorOverload.Models
{
    public class DataList<T>  where T : BookList 
    {
        private T[] datas;
        public DataList()
        {
            datas = [];
        }

        public void Add(T data)
        {
            Array.Resize(ref datas, datas.Length + 1);
            datas[datas.Length - 1] = data;
        }

        public void GetAll()
        {
            
            foreach (var data in datas)
            {
                if (data is BookList book)
                {
                    Console.WriteLine($"Id: {book.Id}, Author: {book.Author}, BookName: {book.BookName}");
                }
                else
                {
                                        Console.WriteLine(data);
                }
                 

            }
        }
    }
}
