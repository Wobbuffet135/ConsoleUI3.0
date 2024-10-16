using CommunityToolkit.Mvvm.ComponentModel;

namespace ConsoleUI3.ViewModels;

public partial class TestViewModel : ViewModelBase
{
    [ObservableProperty] private bool _animationOn = false;     

}