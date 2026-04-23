namespace AppReciclique;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text?.Trim() ?? "";
        string senha = txtSenha.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Atenção", "Preencha e-mail e senha.", "OK");
            return;
        }

        // ALTERADO PARA O PEDIDO:
        // Pamela
        if (email == "pamela@etec.com" && senha == "123")
        {
            AppState.IdUsuario = 1;
            AppState.NomeUsuario = "Pamela";
            AppState.EmailUsuario = "pamela@etec.com";
            AppState.TelefoneUsuario = "(14) 99999-1111";
            AppState.DataNascimentoUsuario = "10/01/2004";
            AppState.EnderecoUsuario = "Rua das Flores, 100 - Marília/SP";
            AppState.CepUsuario = "17500-000";
            AppState.PlanoUsuario = "Plano gratuito";

            // ALTERADO PARA O PEDIDO:
            // pontos e nível
            AppState.Pontos = 120;
            AppState.NivelUsuario = "Bronze";
            AppState.VerificarNivel();

            // ALTERADO PARA O PEDIDO:
            // notificação simples
            AppState.AdicionarNotificacao("Você tem uma coleta agendada em breve");

            await DisplayAlert("Sucesso", "Login realizado!", "OK");
            await Navigation.PushAsync(new ContaUsuarioPage());
        }
        // ALTERADO PARA O PEDIDO:
        // Marcos
        else if (email == "marcos@etec.com" && senha == "123")
        {
            AppState.IdUsuario = 2;
            AppState.NomeUsuario = "Marcos";
            AppState.EmailUsuario = "marcos@etec.com";
            AppState.TelefoneUsuario = "(11) 99999-2222";
            AppState.DataNascimentoUsuario = "20/02/2004";
            AppState.EnderecoUsuario = "Av. Brasil, 200 - Guarulhos/SP";
            AppState.CepUsuario = "07000-000";
            AppState.PlanoUsuario = "Plano gratuito";

            AppState.Pontos = 80;
            AppState.NivelUsuario = "Bronze";
            AppState.VerificarNivel();

            AppState.AdicionarNotificacao("Você tem uma coleta agendada em breve");

            await DisplayAlert("Sucesso", "Login realizado!", "OK");
            await Navigation.PushAsync(new ContaUsuarioPage());
        }
        // ALTERADO PARA O PEDIDO:
        // Maeli
        else if (email == "maeli@etec.com" && senha == "123")
        {
            AppState.IdUsuario = 3;
            AppState.NomeUsuario = "Maeli";
            AppState.EmailUsuario = "maeli@etec.com";
            AppState.TelefoneUsuario = "(11) 99999-3333";
            AppState.DataNascimentoUsuario = "15/03/2005";
            AppState.EnderecoUsuario = "Rua Central, 300 - São Paulo/SP";
            AppState.CepUsuario = "01000-000";
            AppState.PlanoUsuario = "Plano gratuito";

            AppState.Pontos = 160;
            AppState.NivelUsuario = "Bronze";
            AppState.VerificarNivel();

            AppState.AdicionarNotificacao("Você tem uma coleta agendada em breve");

            await DisplayAlert("Sucesso", "Login realizado!", "OK");
            await Navigation.PushAsync(new ContaUsuarioPage());
        }
        // ALTERADO PARA O PEDIDO:
        // Gabriel
        else if (email == "gabriel@etec.com" && senha == "123")
        {
            AppState.IdUsuario = 4;
            AppState.NomeUsuario = "Gabriel";
            AppState.EmailUsuario = "gabriel@etec.com";
            AppState.TelefoneUsuario = "(11) 99999-4444";
            AppState.DataNascimentoUsuario = "05/04/2003";
            AppState.EnderecoUsuario = "Rua Verde, 400 - Osasco/SP";
            AppState.CepUsuario = "06000-000";
            AppState.PlanoUsuario = "Plano gratuito";

            AppState.Pontos = 40;
            AppState.NivelUsuario = "Bronze";
            AppState.VerificarNivel();

            AppState.AdicionarNotificacao("Você tem uma coleta agendada em breve");

            await DisplayAlert("Sucesso", "Login realizado!", "OK");
            await Navigation.PushAsync(new ContaUsuarioPage());
        }
        else
        {
            await DisplayAlert("Erro", "Email ou senha inválidos.", "OK");
        }
    }
}