using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;


namespace ConsoleUI3.ViewModels;

public partial class TestViewModel : ViewModelBase
{
    public TestViewModel()
    {
        Game fortnite = new Game();
        fortnite.Name = "fortnite";
        fortnite.Rating = 4;
        fortnite.Image = "Assets\\gear-icon-2048x2048-5lk2g86a.png";
        AllGamesList.Add(fortnite);

        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
        AllGamesList.Add("Resident Evil");
    }

    public class Game
    {
        [ObservableProperty]
        public string Name;

        [ObservableProperty]
        public object Image;
        [ObservableProperty]
        public float Rating;

    }
    [ObservableProperty] ObservableCollection<Game> _allGamesList = new();
    [ObservableProperty] private bool _animationOn = false;     

}