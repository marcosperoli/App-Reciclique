using AppReciclique.Helpers;

namespace AppReciclique;

public partial class HistoricoPage : ContentPage
{
    SQLiteHelper db;

    public HistoricoPage()
    {
        InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "app.db3");
        db = new SQLiteHelper(dbPath);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var lista = await db.ListarAgendamentos();
        listaHistorico.ItemsSource = lista;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}