namespace MiAppMaui;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

    private async void OnGoToSecondPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MiAppMaui.SecondPage());
    }
}