namespace MauiAppSample;

public class AppShell : Shell
{
    public AppShell()
    {
        Title = "MAUI App";
        Items.Add(new ShellContent
        {
            Title = "Main",
            ContentTemplate = new DataTemplate(() => new MainPage()),
            Route = "MainPage"
        });
    }
}