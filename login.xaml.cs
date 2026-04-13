namespace AppReciclique;

public partial class LoginPage : ContentPage
{
    Dictionary<string, string> usuarios = new Dictionary<string, string>()
{
    { "pamela@etec.com", "123" },
    { "marcos@etec.com", "123" },
    { "maeli@etec.com", "123" },
    { "gabriel@etec.com", "123" }

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
            // 👇 pega nome antes do @
            string nome = email.Split('@')[0];

            // 👇 deixa primeira letra maiúscula
            nome = char.ToUpper(nome[0]) + nome.Substring(1);

            // 👇 salva no AppState
            AppState.NomeUsuario = nome;

            await DisplayAlert("Sucesso", "Login realizado!", "OK");

            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        else
        {
            await DisplayAlert("Erro", "Email ou senha inválidos", "OK");
        }
    }
}