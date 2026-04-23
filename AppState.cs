using Microsoft.Maui.Storage;
using System.Collections.ObjectModel;

namespace AppReciclique
{
    public static class AppState
    {
        public static string UltimoAgendamento { get; set; } = "";

        public static int Pontos
        {
            get => Preferences.Get("pontos", 0);
            set => Preferences.Set("pontos", value);
        }

        public static int IdUsuario { get; set; }
        public static string NomeUsuario { get; set; } = "";
        public static string EmailUsuario { get; set; } = "";
        public static string TelefoneUsuario { get; set; } = "";
        public static string DataNascimentoUsuario { get; set; } = "";
        public static string EnderecoUsuario { get; set; } = "";
        public static string CepUsuario { get; set; } = "";
        public static string PlanoUsuario { get; set; } = "Plano gratuito";
        public static string NivelUsuario { get; set; } = "Bronze";

        public static ObservableCollection<string> Notificacoes { get; set; } = new();

        public static void AdicionarNotificacao(string mensagem)
        {
            if (!Notificacoes.Contains(mensagem))
            {
                Notificacoes.Insert(0, mensagem);
            }
        }

        public static void VerificarNivel()
        {
            string nivelAnterior = NivelUsuario;

            if (Pontos >= 200)
                NivelUsuario = "Ouro";
            else if (Pontos >= 100)
                NivelUsuario = "Prata";
            else
                NivelUsuario = "Bronze";

            if (nivelAnterior != NivelUsuario)
            {
                AdicionarNotificacao($"Parabéns! Você subiu para o nível {NivelUsuario}!");
            }
        }
    }
}