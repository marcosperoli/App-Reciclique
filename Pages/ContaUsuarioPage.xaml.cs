namespace AppReciclique;

public partial class ContaUsuarioPage : ContentPage
{
    public ContaUsuarioPage()
    {
        InitializeComponent();

        // ALTERADO PARA O PEDIDO:
        // mostrar na tela os dados do usuário que fez login

        lblId.Text = $"ID do usuário: {AppState.IdUsuario}";
        lblNome.Text = $"Nome: {AppState.NomeUsuario}";
        lblEmail.Text = $"Email: {AppState.EmailUsuario}";
        lblNascimento.Text = $"Data de nascimento: {AppState.DataNascimentoUsuario}";
        lblTelefone.Text = $"Telefone: {AppState.TelefoneUsuario}";
        lblEndereco.Text = $"Endereço: {AppState.EnderecoUsuario}";
        lblCep.Text = $"CEP: {AppState.CepUsuario}";
        lblPlano.Text = AppState.PlanoUsuario;

        // NOVO
        lblPontos.Text = $"Pontos: {AppState.Pontos}";
        lblNivel.Text = $"Nível: {AppState.NivelUsuario}";

        // NOVO: boas-vindas
        lblBoasVindas.Text = $"Olá, {AppState.NomeUsuario}!";

        // NOVO: último agendamento
        if (string.IsNullOrWhiteSpace(AppState.UltimoAgendamento))
            lblUltimoAgendamento.Text = "Último agendamento: nenhum agendamento registrado";
        else
            lblUltimoAgendamento.Text = $"Último agendamento: {AppState.UltimoAgendamento}";

        // NOVO: Barra de progresso
        if (AppState.NivelUsuario == "Bronze")
            progressNivel.Progress = AppState.Pontos / 100.0;
        else if (AppState.NivelUsuario == "Prata")
            progressNivel.Progress = (AppState.Pontos - 100) / 100.0;
        else
            progressNivel.Progress = 1;

        // NOVO: Badge
        if (AppState.NivelUsuario == "Bronze")
        {
            lblBadge.Text = "🥉 Bronze";
            lblBadge.TextColor = Colors.SaddleBrown;
        }
        else if (AppState.NivelUsuario == "Prata")
        {
            lblBadge.Text = "🥈 Prata";
            lblBadge.TextColor = Colors.Gray;
        }
        else
        {
            lblBadge.Text = "🥇 Ouro";
            lblBadge.TextColor = Colors.Gold;
        }


        // ALTERADO PARA O PEDIDO:
        // texto institucional no final da tela
        lblApoio.Text = "Aplicativo apoiado pela Prefeitura de Marília - SP";
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    // NOVO: abrir notificações
    private async void OnNotificacoesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotificacoesPage());
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Sair", "Deseja sair da conta?", "Sim", "Não");

        if (confirmar)
        {
            // ALTERADO PARA O PEDIDO:
            // limpar todos os dados do usuário ao sair

            AppState.IdUsuario = 0;
            AppState.NomeUsuario = "";
            AppState.EmailUsuario = "";
            AppState.TelefoneUsuario = "";
            AppState.DataNascimentoUsuario = "";
            AppState.EnderecoUsuario = "";
            AppState.CepUsuario = "";
            AppState.PlanoUsuario = "Plano gratuito";

            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}