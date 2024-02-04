using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace ToDoApp
{
    internal class ToDoModel
    {
        public List<ToDo> ToDos { get; set; } = [
            new ToDo(0, "Buy milk", DateTime.Now),
            new ToDo(1, "Buy new PC", new DateTime(2023, 12, 24), true),
            new ToDo(2, "Buy chocolate", new DateTime(2024, 2, 14), true)
        ];

        public void UpdateName(ToDo todo, string name) => Debug.WriteLine($"Name has been updated to {name} in ToDo#{todo.Id}");
        public void UpdateDeadline(ToDo todo, DateTime deadline) => Debug.WriteLine($"Deadline has been updated to {deadline} in ToDo#{todo.Id}");
        public void UpdateCompleted(ToDo todo, bool completed) => Debug.WriteLine($"Completed has been updated to {completed} in ToDo#{todo.Id}");
        public void Add(ToDo todo) => Debug.WriteLine($"ToDo#{todo.Id} has been added");
        public void Delete(ToDo todo) => Debug.WriteLine($"ToDo#{todo.Id} has been deleted");
    }

    partial class ToDo(int id, string name, DateTime deadline, bool completed = false) : ObservableObject
    {
        public int Id { get; set; } = id;
        [ObservableProperty]
        private string _name = name;
        [ObservableProperty]
        private DateTime _deadline = deadline;
        [ObservableProperty]
        private bool _completed = completed;
    }
}
