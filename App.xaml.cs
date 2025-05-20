namespace MiAppMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        MainPage = new NavigationPage(new SecondPage());
        MainPage = new NavigationPage(new MainPage());
    }
}
