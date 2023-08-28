namespace Survey5022358;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
        "Alianza Lima",
        "America",
        "Boca juniors",
        "Caracas Fc",
        "Colo-Colo",
        "Penarol",
        "Real Madrid",
        "Saprisa"
    };
    public SurveyDetailsView()
	{
		InitializeComponent();
	}
	private async void FavoriteTeamButtonButton_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTitle, null, null, teams);
        if(!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }

    private async void OkButton_Clicked(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(NameEntry.Text)||string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }
        var newSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birhdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };
        MessagingCenter.Send((ContentPage)this,
        Messages.NewSurveyComplete, newSurvey
        );
        await Navigation.PopAsync();
    }
}