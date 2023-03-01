namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
    public AstronomicalBodiesPage()
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync($"{nameof(AstronomicalBodiesPage)}?astroname=comet"); 
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync($"{nameof(AstronomicalBodiesPage)}?astroname=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync($"{nameof(AstronomicalBodiesPage)}?astroname=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync($"{nameof(AstronomicalBodiesPage)}?astroname=sun");
    }
}