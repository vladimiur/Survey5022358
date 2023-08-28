using static System.Net.Mime.MediaTypeNames;
namespace Survey5022358;

public partial class SurveysView : ContentPage
{
	public SurveysView()
	{
		InitializeComponent();
		MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) =>
		{
			SurveyPanel.Children.Add(new Label() { Text = args.ToString() });
		});
	}

	private async void AddSurvetButoon_Cliked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SurveyDetailsView());
	}
}