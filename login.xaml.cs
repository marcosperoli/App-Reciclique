namespace AppReciclique;

public partial class LoginPage : ContentPage
{
    Dictionary<string, string> usuarios = new Dictionary<string, string>()
{
    { "pamela@email.com", "123" },
    { "marcos@email.com", "123" },
    { "maeli@email.com", "123" },
    { "gabriel@email.com", "123" }

    };

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (usuarios.ContainsKey(email) && usuarios[email] == senha)
        {
            await DisplayAlert("Sucesso", "Login realizado!", "OK");


            // 🔥 FORÇA A TROCA DE TELA
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        else
        {
            await DisplayAlert("Erro", "Email ou senha inválidos", "OK");
        }
    
       
       


    }
}