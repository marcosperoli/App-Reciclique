namespace AppReciclique.Pages.Educacao;

public partial class Nivel5Page : ContentPage
{
	public Nivel5Page()
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