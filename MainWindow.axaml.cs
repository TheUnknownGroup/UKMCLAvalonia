using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia;
using Avalonia.Styling;
using UKMCLAvalonia.app;

namespace UKMCLAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Classes.Add("main");
    }
    private void OnHelloClick(object? sender, RoutedEventArgs e)
    {
        var user = UserInp.Text;
        var pass = PassInp.Text;
        MessageBoxManager.ShowMessageBox(this, "Greeting", $"Hello, {user}!\nYour password is: {pass}");
    }
    private void OnThemeTog(object? sender, RoutedEventArgs e)
    {
        var isDark = ThemeT.IsChecked ?? false;
        Application.Current!.RequestedThemeVariant =
            isDark ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}