using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MiAppMaui;
public partial class SecondPage : ContentPage
{

    public SecondPage()

    {
        InitializeComponent();
    }

    private async void OnGoToThirdPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ThirdPage());
    }
    private async void OnGoToFourthPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FourthPage());
    }
    private async void OnGoToMainPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MiAppMaui.MainPage());
    }
}