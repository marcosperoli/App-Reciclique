using System;

namespace AppReciclique;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    private async void OnAgendarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AgendamentoPage());
    }

    private async void OnPontosClicked(object sender, EventArgs e)
    {
        // Placeholder navigation or action for Pontos
        await Navigation.PushAsync(new PontuacaoPage());
    }

    private async void OnHistoricoClicked(object sender, EventArgs e)
    {
        // Placeholder navigation or action for Histórico
        await Navigation.PushAsync(new HistoricoPage());
    }

    private async void OnEducacaoClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new EducacaoPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnMapaClicked(object sender, EventArgs e)
    {
        // Placeholder action for Mapa; replace with Navigation.PushAsync(new MapaPage()) if you add a MapaPage
        await Navigation.PushAsync(new MapaPage());
    }

    private async void OnNotificacoesClicked(object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        // Placeholder action for Avisos
        await Navigation.PushAsync(new NotificacoesPage());
    }

    private async void OnContaClicked(object sender, EventArgs e)
    {
        // Navigate to existing ContaUsuarioPage
        await Navigation.PushAsync(new ContaUsuarioPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}

























