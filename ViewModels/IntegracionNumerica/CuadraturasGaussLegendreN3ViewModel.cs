using CodexGigas.Services;
using Newtonsoft.Json;

namespace CodexGigas.ViewModels.IntegracionNumerica
{
    [QueryProperty(nameof(Funcion), "funcion")]
    public partial class CuadraturasGaussLegendreN3ViewModel (IDataServices dataServices) : BaseViewModel
    {
        private readonly IDataServices _dataServices = dataServices;

        [ObservableProperty]
        private string _funcion;

        [ObservableProperty]
        private string _liminf;

        [ObservableProperty]
        private string _limsup;

        [ObservableProperty]
        private string _function;

        [RelayCommand]
        public void SetValores()
        {
            if (!string.IsNullOrWhiteSpace(Funcion) && Funcion.Contains('|'))
            {
                string[] valores = Funcion.Split('|');

                if (valores.Length == 2)
                {
                    Function = valores[0].Trim(' ');
                    Liminf = valores[1].Trim(' ');
                    Limsup = valores[2].Trim(' ');
                }
            }
        }

        [RelayCommand]
        public async Task CalcularAsync()
        {
            string response = await _dataServices.EnviarDatosAsync(13, X, Y, string.Empty, 0, 0, 0);
            if (response.Contains("Error"))
            {
                await App.Current.MainPage.DisplayAlert("Error", response, "Aceptar");
                return;
            }
            else
            {
                dynamic ans = JsonConvert.DeserializeObject(response);
            }

        }
    }
}
