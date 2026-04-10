namespace AppReciclique;

public partial class AjudaPage : ContentPage
{
    public AjudaPage()
    {
        InitializeComponent();
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensagem enviada",
            "Em breve entraremos em contato!",
            "OK");

        txtNome.Text = "";
        txtTelefone.Text = "";
        txtMensagem.Text = "";
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}