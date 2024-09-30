﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ConsoleUI3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<string> _gameList = new();

    [ObservableProperty]
    string _tbxInputText = "";


    [RelayCommand]
    private void AddItem()
    {
        GameList.Add(TbxInputText);
    }
}
