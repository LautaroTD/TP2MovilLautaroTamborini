namespace MiAppMaui;

public partial class FourthPage : ContentPage
{
	public FourthPage()
	{
		InitializeComponent();
	}

    private async void OnGoToSecondPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MiAppMaui.SecondPage());
    }
}