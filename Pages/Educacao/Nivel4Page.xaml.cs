namespace AppReciclique.Pages.Educacao;

public partial class Nivel4Page : ContentPage
{
	public Nivel4Page()
	{
		InitializeComponent();
	}

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}