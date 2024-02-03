using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ToDoApp
{
    internal partial class ToDoViewModel: ObservableObject
    {
        private ToDoModel _model;

        public ObservableCollection<ToDo> ListViewRows { get; set; }

        public ToDoViewModel()
        {
             _model = new();
             ListViewRows = new(_model.ToDos);
        }   
    }
}
