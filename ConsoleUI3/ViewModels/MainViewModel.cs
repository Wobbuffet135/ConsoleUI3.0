using System;

namespace ConsoleUI3.ViewModels;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _CurrentViewModel = new HuvudmenyViewModel();


    [RelayCommand]
    private void ActivateView(string deviceName)
    {

        CurrentViewModel = deviceName switch
        {
            // get it from dependency injection
            "Huvudmeny" => new HuvudmenyViewModel(),

            _ => throw new ArgumentException($"unknown device name {deviceName}")
        };
    }

}
