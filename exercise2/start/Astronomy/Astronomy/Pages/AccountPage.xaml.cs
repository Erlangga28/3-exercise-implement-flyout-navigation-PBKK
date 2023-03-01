namespace Astronomy.Pages;

[QueryProperty(nameof(Info), "info")]
public partial class Information : ContentPage
{
    public Information()
    {
        InitializeComponent();
    }

    string info;
    public string Info
    {
        get => info;
        set
        {
            info = value;

            // this is a custom function to update the UI immediately
            UpdateInfoUI(info);
        }
    }

    void UpdateInfoUI(string info)
    {
        InformationBody body = FindInfoData(info);

        Title = body.Course;

        lblTitle.Text = body.Title;
        lblId.Text = body.Id;
        lblName.Text = body.Name;
        lblEmoji.Text = body.Emoji;
    }

    InformationBody FindInfoData(string infoBodyName)
    {
        return infoBodyName switch
        {
            "MyAcc" => MyAccount.myAcc,
            "Myacc2" => MyAccount.myAcc,
            _ => throw new ArgumentException()
        };
    }
}