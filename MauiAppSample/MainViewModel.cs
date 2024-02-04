using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppSample;

public partial class MainViewModel : ObservableObject
{
    private int _counter;
    
    private string _text = string.Empty;
    private string _buttonText = string.Empty;

    public MainViewModel()
    {
        IncreaseTextButtonCommand = new RelayCommand(IncreaseTextButton);
        DecreaseTextButtonCommand = new RelayCommand(DecreaseTextButton);
    }

    public string Text
    {
        get => _text;
        set => SetProperty(ref _text, value);
    }

    public string ButtonText
    {
        get => _buttonText;
        set => SetProperty(ref _buttonText, value);
    }

    public ICommand IncreaseTextButtonCommand { get; }
    public ICommand DecreaseTextButtonCommand { get; }
    
    [RelayCommand]
    private void SetText()
    {
        Debug.WriteLine("Text is set.");
        Text = "New Text";
    }
    
    private void IncreaseTextButton()
    {
        Debug.WriteLine("Text is set.");
        _counter++;
        ButtonText = $"Button - {_counter}";
    }
    
    private void DecreaseTextButton()
    {
        Debug.WriteLine("Text is set.");
        _counter--;
        ButtonText = $"Button - {_counter}";
    }
}