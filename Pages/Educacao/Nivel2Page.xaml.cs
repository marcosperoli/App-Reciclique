namespace AppReciclique.Pages.Educacao;

public partial class Nivel2Page : ContentPage
{
	public Nivel2Page()
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