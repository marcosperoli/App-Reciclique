namespace AppReciclique.Pages.Educacao;

public partial class Nivel1Page : ContentPage
{
    public Nivel1Page()
    {
        InitializeComponent();
    }

    async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    async void OnVidroClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Separação", "Abrir conteúdo sobre separação de lixo", "OK");
    }

    async void OnPlasticoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Plástico", "Abrir conteúdo sobre plástico", "OK");
    }

    async void OnPapelClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Papel", "Abrir conteúdo sobre papel", "OK");
    }

    async void OnMetalClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Dicas", "Abrir dicas ambientais", "OK");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}