namespace Astronomy.Pages;


public partial class AccountBodiesPage: ContentPage
{
    public AccountBodiesPage()
    {
        InitializeComponent();
        btnMyAcc1.Clicked += async (s, e) => await Shell.Current.GoToAsync("informationdetails?info=info1");
        btnMyAcc2.Clicked += async (s, e) => await Shell.Current.GoToAsync("informationdetails?info=info2");
    }
}