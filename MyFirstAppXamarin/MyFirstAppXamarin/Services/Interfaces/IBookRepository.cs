using MyFirstAppXamarin.Model;
using System.Collections.Generic;

namespace MyFirstAppXamarin.Services
{
    public interface IBookRepository
    {
        void CreateDatabase();

        void Save(Book book);

        IList<Book> GetAll();
    }
}
