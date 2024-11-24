using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ConsoleUI3.ViewModels;

public partial class HuvudmenyViewModel : ViewModelBase
{

    public HuvudmenyViewModel()
    {
        MainMenuList.Add("Fortnite");
        MainMenuList.Add("Fortnite 2");
        MainMenuList.Add("Overwatch");
        MainMenuList.Add("Minecraft");
        MainMenuList.Add("Roblox");
        MainMenuList.Add("tf2");
        MainMenuList.Add("pubg mobile");
        MainMenuList.Add("mario kart double dash");
        MainMenuList.Add("ett annat spel");
        MainMenuList.Add("spel igen");
        MainMenuList.Add("jag kommer inte");
        MainMenuList.Add("på fler");
        MainMenuList.Add("spel");
        MainMenuList.Add("slutet på listna");
        
    }


    [ObservableProperty] ObservableCollection<object> _mainMenuList = new();
    [ObservableProperty] private int _mainSelectedItemIndex = 2;


}

