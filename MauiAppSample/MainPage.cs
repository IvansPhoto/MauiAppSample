using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Layouts;
using CommunityToolkit.Maui.Markup;

namespace MauiAppSample;

public class MainPage : ContentPage
{
    public MainPage()
    {
        Content = new DockLayout
        {
            {
                new Label()
                    .Text("Label")
                    .FontSize(25)
                    .Size(-1, 100)
                    .Bind(Label.TextProperty, static (MainViewModel vm) => vm.ButtonText, mode: BindingMode.OneWay),
                DockPosition.Top
            },
            {
                new Button()
                    .Text("Bottom")
                    .Size(-1, 100)
                    .Bind(Button.TextProperty, static (MainViewModel vm) => vm.Text)
                    .BindCommand(static (MainViewModel vm) => vm.SetTextCommand,
                        parameterGetter: static (MainViewModel vm) => vm.Text,
                        parameterBindingMode: BindingMode.OneWay,
                        commandBindingMode: BindingMode.OneWayToSource),
                DockPosition.Bottom
            },

            {
                new Button()
                    .Size(100, -1)
                    .Text("Left 1")
                    .BindCommand(getter: static (MainViewModel vm) => vm.IncreaseTextButtonCommand),
                DockPosition.Left
            },
            {
                new Button()
                    .Size(100, -1)
                    .Text("Right 1")
                    .BindCommand(getter: static (MainViewModel vm) => vm.DecreaseTextButtonCommand),
                DockPosition.Right
            },

            new Entry()
                .Placeholder("Some text")
                .FontSize(25)
                .Bind(Entry.TextProperty,
                    getter: static (MainViewModel vm) => vm.Text,
                    setter: static (vm, s) => vm.Text = s,
                    mode: BindingMode.TwoWay)
        };
    }
}