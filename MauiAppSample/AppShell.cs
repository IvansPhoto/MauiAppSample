namespace MauiAppSample;

public class AppShell : Shell
{
    public AppShell(MainPage mainPage)
    {
        Title = "MAUI App";
        Items.Add(mainPage);
    }
}