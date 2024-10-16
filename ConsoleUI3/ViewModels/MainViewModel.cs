﻿using System;

namespace ConsoleUI3.ViewModels;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel = new HuvudmenyViewModel();


    [RelayCommand]
    private void ActivateView(string deviceName)
    {

        CurrentViewModel = deviceName switch
        {
            // get it from dependency injection - ingen aning vad det här betyder lol
            "Huvudmeny" => new HuvudmenyViewModel(),

            
            //sker om man försöker byta till ett fönster som inte finns
            _ => throw new ArgumentException($"unknown device name {deviceName}")
        };
    }

}
