using Microsoft.Maui.Storage;

namespace AppReciclique
{
    public static class AppState
    {
        public static string UltimoAgendamento { get; set; }

        public static int Pontos
        {
            get => Preferences.Get("pontos", 0);
            set => Preferences.Set("pontos", value);
        }

        public static string NomeUsuario { get; set; } = "";
    }
}
