using Microsoft.Maui.Controls;

namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent(); // relie le XAML au code-behind
    }

    private void OnGreetClicked(object sender, EventArgs e)
    {
        var name = NameEntry.Text ?? "ami";
        GreetingLabel.Text = $"Bonjour, {name} 👋";
    }

    // private void OnCountClicked(object sender, EventArgs e)
    // {
    //     count++;
    //     CountLabel.Text = $"Compteur: {count}";
    // }
}
