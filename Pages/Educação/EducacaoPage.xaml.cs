namespace AppReciclique;

using AppReciclique.Pages.Educacao;
using AppReciclique.Pages.Educação;

public partial class EducacaoPage : ContentPage
{
    public EducacaoPage()
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

    async void Nivel1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel1Page());
    }

    async void Nivel2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel2Page());
    }

    async void Nivel3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel3Page());
    }

    async void Nivel4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel4Page());
    }

    async void Nivel5_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel5Page());
    }

    async void Nivel6_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Nivel6Page());
    }

    async void Bonus_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BonusPage());
    }

}