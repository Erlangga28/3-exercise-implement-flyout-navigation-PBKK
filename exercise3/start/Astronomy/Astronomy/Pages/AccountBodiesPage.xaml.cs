namespace Astronomy;

public partial class AccountBodiesPage : ContentPage
{
	public AccountBodiesPage()
	{
		InitializeComponent();
        btnMyAcc1.Clicked += async (s, e) => await Shell.Current.GoToAsync("MyAccountdetails?myAcc=myAcc1");
        btnMyAcc2.Clicked += async (s, e) => await Shell.Current.GoToAsync("MyAccountdetails?myAcc=myAcc2");
    }
}
