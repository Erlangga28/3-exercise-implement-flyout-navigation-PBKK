namespace Astronomy.Pages;

[QueryProperty(nameof(MyAcc), "myAcc")]

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    string myAcc;
    public string MyAcc
    {
        get => myAcc;
        set
        {
            myAcc = value;

            // this is a custom function to update the UI immediately
            UpdateMyAccUI(myAcc);
        }
    }

    private void UpdateMyAccUI(string myAcc)
    {
        throw new NotImplementedException();
    }
}
