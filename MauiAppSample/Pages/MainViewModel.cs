using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppSample.Pages;

[INotifyPropertyChanged]
public partial class MainViewModel
{
    private int _counter = 0;
    
    [ObservableProperty]
    private string _text = "Main text";

    [ObservableProperty]
    private string _buttonText = "Button text";
    
    [RelayCommand]
    private void SetText()
    {
        Debug.WriteLine("Text is set.");
        Text = "New Text";
    }
    
    [RelayCommand]
    private void IncreaseTextButton()
    {
        Debug.WriteLine("Text is set.");
        _counter++;
        ButtonText = $"Button - {_counter}";
    }
    
        
    [RelayCommand]
    private void DecreaseTextButton()
    {
        Debug.WriteLine("Text is set.");
        _counter--;
        ButtonText = $"Button - {_counter}";
    }
}