namespace Survey5022358;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new SurveysView());
	}
}
