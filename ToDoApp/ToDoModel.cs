namespace ToDoApp
{
    internal class ToDoModel
    {
        public List<ToDo> ToDos { get; set; } = [
            new ToDo("Buy milk", DateTime.Now),
            new ToDo("Buy new PC", new DateTime(2023, 12, 24), true),
            new ToDo("Buy chocolate", new DateTime(2024, 2, 14), true)
        ];
    }

    internal class ToDo(string name, DateTime deadline, bool completed = false)
    {
        public string Name { get; set; } = name;
        public DateTime Deadline { get; set; } = deadline;
        public bool Completed { get; set; } = completed;
    }
}
