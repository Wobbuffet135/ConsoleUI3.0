using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;


namespace ConsoleUI3.ViewModels;

public partial class TestViewModel : ViewModelBase
{
    public TestViewModel()
    {
        Game fortnite = new Game();
        fortnite._name = "fortnite";
        fortnite._rating = 4;
        fortnite._image = "Assets\\gear-icon-2048x2048-5lk2g86a.png";
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);
        AllGamesList.Add(fortnite);


    }
    [ObservableObject]
    public partial class Game
    {
        [ObservableProperty]
        public string _name = "";

        [ObservableProperty]
        public object _image = "";

        [ObservableProperty]
        public float _rating = 0;

    }
    [ObservableProperty] ObservableCollection<Game> _allGamesList = new();
    [ObservableProperty] private bool _animationOn = false;     

}