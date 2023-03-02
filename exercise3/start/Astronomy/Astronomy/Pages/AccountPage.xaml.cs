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

    void UpdateMyAccUI(string myAcc)
    {
        AccountBody send = FindMyAccData(myAcc);

        lblTitle.Text = send.Title;
        lblName.Text = send.Name;
        lblNRP.Text = send.NRP;
    }

    AccountBody FindMyAccData(string myAccSendName)
    {
        return myAccSendName switch
        {
            "myAcc1" => AccountData.MyAcc1,
            _ => throw new ArgumentException()
        };
    }
}

