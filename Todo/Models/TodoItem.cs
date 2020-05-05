using SQLite;

namespace Todo
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Jokes { get; set; }
        public bool Done { get; set; }
    }
}

