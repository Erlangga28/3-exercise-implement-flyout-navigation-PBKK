namespace Astronomy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Routing.RegisterRoute("AccountDetails", typeof(AccountBodiesPage));
    }
}
