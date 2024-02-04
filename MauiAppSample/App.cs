using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace MauiAppSample;

public class App : Application
{
    public App(AppShell appShell)
    {
        MainPage = appShell;
    }
}