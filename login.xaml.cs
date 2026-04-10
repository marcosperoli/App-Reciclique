namespace AppReciclique;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (email == "usuario@email.com" && senha == "123")
        {
            await Navigation.PushAsync(new ContaUsuarioPage());
        }
        else
        {
            await DisplayAlert("Erro", "Email ou senha inválidos", "OK");
        }
    }
}