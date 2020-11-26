using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Services
{
    public class JsonBookRepository
    {
        string JsonFileName= @"C:\Users\hald_\OneDrive\Dokumenter\skole\Software konstruktion\RP_UnSolved-master\RP_UnSolved-master\RazorPages_Exercises\Book_StoreV10\Book_StoreV10\Data\JsonBooksStock.json";

        public List<Book> GetAllBooks()
        {
            return JsonFileReader.ReadJsonBook(JsonFileName);
        }
        public void AddBook(Book book)
        {
            List<Book> books = GetAllBooks().ToList();
            books.Add(book);
            JsonFileWritter.WriteToJsonBook(books, JsonFileName);
        }
    }
}
