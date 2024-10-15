using Avalonia.Controls;
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

    [ObservableProperty]
    bool _errorAlertIsVisible = false;

    [ObservableProperty]
    Image _coverArt;

    [RelayCommand]
    private void AddItem()
    {

    GameList.Add(TbxInputText);
    }

    [RelayCommand]
    private void RemoveItem()
    {
        if (GameList.Count > 0 && SelectedGameIndex != -1 )
        {
            int tempIndex = SelectedGameIndex;
            ErrorAlertIsVisible = false;
            GameList.RemoveAt(SelectedGameIndex);
            SelectedGameIndex = tempIndex - 1;
        }
            
        else
        {
            ErrorAlertIsVisible = true;
        }
    }
    }
