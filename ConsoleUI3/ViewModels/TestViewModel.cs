using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;


namespace ConsoleUI3.ViewModels;

public partial class TestViewModel : ViewModelBase
{
    public TestViewModel()
    {
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
    }


    [ObservableProperty] ObservableCollection<object> _allGamesList = new();
    [ObservableProperty] private bool _animationOn = false;     

}