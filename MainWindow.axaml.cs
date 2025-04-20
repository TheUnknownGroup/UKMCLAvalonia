using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia;
using Avalonia.Styling;
using UKMCLAvalonia.app;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using Avalonia.Platform;

namespace UKMCLAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Icon = new WindowIcon("../../../Assets/icon.png");
        //var back = new Grid();
        //back.Background = new ImageBrush
        //{
        //    Source = new Bitmap("avares://UKMCLAvalonia-Windows-en_US+0.0.0/Assets/background.png")
        //};
        //var uri = new Uri("avares://UKMCLAvalonia-Windows-en_US+0.0.0/Assets/background.png");
        //if (AssetLoader.Exists(uri))
        //{
        //    Console.WriteLine("Image found");
        //}
        //else
        //{
        //    Console.WriteLine("Not found");
        //}
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