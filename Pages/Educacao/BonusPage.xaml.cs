namespace AppReciclique.Pages.Educacao;

public partial class BonusPage : ContentPage
{
	public BonusPage()
	{
		InitializeComponent();
	}

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
