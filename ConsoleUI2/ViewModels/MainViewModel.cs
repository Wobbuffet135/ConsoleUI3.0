using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ConsoleUI2.ViewModels;

public partial class MainViewModel : ViewModelBase
{
[ObservableProperty]
ObservableCollection<string> _gameList = new();

    [ObservableProperty]
    string _tbxInputText = "";

    [ObservableProperty]
    int _selectedGameIndex;


    [RelayCommand]
    private void AddItem()
    {
    GameList.Add(TbxInputText);
    }

    [RelayCommand]
    private void RemoveItem()
    {
    GameList.RemoveAt(SelectedGameIndex);
    }
    }
