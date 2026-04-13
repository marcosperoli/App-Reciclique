namespace AppReciclique;

public partial class ContaUsuarioPage : ContentPage
{
    public ContaUsuarioPage()
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

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Sair", "Deseja sair da conta?", "Sim", "Não");

        if (confirmar)
        {
            AppState.NomeUsuario = "";
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }
}
