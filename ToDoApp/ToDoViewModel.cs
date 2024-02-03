using CommunityToolkit.Mvvm.ComponentModel;

namespace ToDoApp
{
    internal partial class ToDoViewModel: ObservableObject
    {
        [ObservableProperty]
        private List<RowItems> _listViewRows = new();

        public ToDoViewModel()
        {
            _listViewRows.Add(new RowItems("Buy milk", DateTime.Now));
            _listViewRows.Add(new RowItems("Buy new PC", new DateTime(2023, 12, 24), true));
            _listViewRows.Add(new RowItems("Buy chocolate", new DateTime(2024, 2, 14), true));           
        }   
    }

    public partial class RowItems(string name, DateTime deadline, bool completed=false): ObservableObject
    {
        [ObservableProperty]
        private string _name = name;

        [ObservableProperty]
        private DateTime _deadline = deadline;
        
        [ObservableProperty]
        private bool _completed = completed;
    }
}
