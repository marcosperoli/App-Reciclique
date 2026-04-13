namespace AppReciclique;

public partial class MapaPage : ContentPage
{
    public MapaPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await CarregarMapaAsync();
    }

    private async Task CarregarMapaAsync()
    {
        try
        {
            double latitude = -23.5505;
            double longitude = -46.6333;

            // TENTAR OBTER A LOCALIZAÇÃO REAL DO USUÁRIO
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            if (status == PermissionStatus.Granted)
            {
                var localizacao = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(10)
                });

                if (localizacao != null)
                {
                    latitude = localizacao.Latitude;
                    longitude = localizacao.Longitude;
                }
            }

            // CARREGA O MAPA HTML COM A LOCALIZAÇÃO OBTIDA
            string html = GerarHtmlMapa(latitude, longitude);
            MapaWebView.Source = new HtmlWebViewSource { Html = html };
        }
        catch (Exception)
        {
            // SE HOUVER QUALQUER ERRO, MOSTRA O MAPA DE SÃO PAULO COMO PADRÃO
            string html = GerarHtmlMapa(-23.5505, -46.6333);
            MapaWebView.Source = new HtmlWebViewSource { Html = html };
        }
    }


    private string GerarHtmlMapa(double latitude, double longitude)
    {
        string lat = latitude.ToString(System.Globalization.CultureInfo.InvariantCulture);
        string lng = longitude.ToString(System.Globalization.CultureInfo.InvariantCulture);

        return $@"
        <!DOCTYPE html>
            <html>
            <head>
            <meta charset='utf-8'/>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <style>
            body {{ margin: 0; padding: 0; }}
             iframe {{ width: 100vw; height: 100vh; border: none; }}
             </style>
             </head>
             <body>
             <iframe src='https://maps.google.com/maps?q={lat},{lng}&z=15&output=embed' allowfullscreen></iframe>
             </body>
             </html>";
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