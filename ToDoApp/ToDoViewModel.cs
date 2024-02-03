using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;
using static ToDoApp.ToDoModel;

namespace ToDoApp
{
    internal partial class ToDoViewModel: ObservableObject
    {
        private ToDoModel _model;

        [ObservableProperty]
        private List<ToDo> _listViewRows;

        partial void OnListViewRowsChanged(List<ToDo> value)
        {
            Debug.WriteLine(value);
        }

        public ToDoViewModel()
        {
             _model = new();
             _listViewRows = new(_model.ToDos);
            foreach (var todo in _listViewRows)
            {
                todo.PropertyChanged += ToDoPropertyChanged;
            }
        }

        private void ToDoPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender is ToDo todo)
            {
                switch (e.PropertyName)
                {
                    case nameof(ToDo.Name):
                        _model.UpdateName(todo, todo.Name);
                        break;
                    case nameof(ToDo.Deadline):
                        _model.UpdateDeadline(todo, todo.Deadline);
                        break;
                    case nameof(ToDo.Completed):
                        _model.UpdateCompleted(todo, todo.Completed);
                        break;
                }
            }
        }
    }
}
