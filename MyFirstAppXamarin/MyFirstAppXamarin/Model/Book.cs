using SQLite.Net.Attributes;

namespace MyFirstAppXamarin.Model
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set;}
        public string Author { get; set; }
    }
}
