namespace AppReciclique;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        var navPage = new NavigationPage(new LoginPage());
        MainPage = navPage;

        // Preferir acessar a Page pela coleção de Windows (single-window: Windows[0].Page)
        var nav = this.Windows.Count > 0 ? this.Windows[0].Page as NavigationPage : navPage;

        if (nav != null)
        {
            nav.BarBackgroundColor = Color.FromArgb("#2E7D32");
            nav.BarTextColor = Colors.White;
        }
    }
}