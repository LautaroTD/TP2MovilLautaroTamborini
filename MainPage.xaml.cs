using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiAppMaui;

public partial class MainPage : ContentPage
{
    
    public MainPage()
	{
		InitializeComponent();
    }

    public class MiViewModel : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async void OnGoToSecondPageClicked(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text?.Trim();
        string codigo = CodigoEntry.Text?.Trim();

        if (nombre == "NombreDeEjemplo" && codigo == "CodigoDeEjemplo")
        {
            await Navigation.PushAsync(new SecondPage());
        }
        else
        {
            await DisplayAlert("Error", "Nombre o codigo incorrecto", "OK");
        }
    }

}

