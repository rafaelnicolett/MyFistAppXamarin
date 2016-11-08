using MyFirstAppXamarin.Model;
using PCLStorage;
using SQLite.Net;
using SQLite.Net.Interop;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyFirstAppXamarin.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ISQLitePlatformService _sqlitePlatformService;
        private readonly ISQLitePlatform _sqlitePlatform;
        private readonly IFolder _folder;

        private SQLiteConnection _connection;
        private readonly object _lock = new object();
        private string _dbPath;

        public BookRepository(ISQLitePlatformService sqlitePlatformService)
        {
            _sqlitePlatformService = sqlitePlatformService;
            _sqlitePlatform = _sqlitePlatformService.GetPlatform();
        }

        public void CreateDatabase()
        {
            _dbPath = Path.Combine(_folder.Path, "book.sql");

            if (_connection == null)
                _connection = new SQLiteConnection(_sqlitePlatform, _dbPath,
                    SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);

            _connection.CreateTable<Book>();
        }

        public void Save(Book book)
        {
            lock (_lock)
            {
                _connection.Insert(book);
            }
        }

        public IList<Book> GetAll()
        {
            lock (_lock)
            {
                var result = _connection.Table<Book>().ToList();

                return result;
            }
        }
    }
}
