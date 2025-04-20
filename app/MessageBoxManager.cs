using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;

namespace UKMCLAvalonia.app;
public static class MessageBoxManager
{
    public static async void ShowMessageBox(Window owner, string title, string message)
    {
        var dialog = new Window
        {
            Title = title,
            Width = 300,
            Height = 150,
            CanResize = false,
            WindowStartupLocation = WindowStartupLocation.CenterOwner,
            HorizontalContentAlignment = HorizontalAlignment.Center,
            Icon = new WindowIcon("../../../../../Assets/icon.png")
        };
        var okButton = new Button
        {
            Content = "OK",
            Width = 60,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalContentAlignment = VerticalAlignment.Bottom
        };
        var text = new TextBlock
        {
            Text = message
        };
        okButton.Click += (_, _) => dialog.Close();
        dialog.Content = new StackPanel
        {
            Margin = new Thickness(20),
            Spacing = 10,
            Children =
            {
                text,
                okButton
            }
        };
        await dialog.ShowDialog(owner);
    }
}
