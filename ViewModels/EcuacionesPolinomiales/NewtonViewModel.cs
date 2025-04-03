using Newtonsoft.Json;
using CodexGigas.Services;

namespace CodexGigas.ViewModels.EcuacionesPolinomiales
{
    [QueryProperty(nameof(Funcion), "funcion")]
    public partial class NewtonViewModel(IDataServices dataServices) : BaseViewModel
    {
        private readonly IDataServices _dataServices = dataServices;
        [ObservableProperty]
        private string _funcion;

        [ObservableProperty]
        private string _function;

        [ObservableProperty]
        private float _valI;

        [RelayCommand]
        public void SetValores()
        {
            if (!string.IsNullOrWhiteSpace(Funcion) && Funcion.Contains('|'))
            {
                string[] valores = Funcion.Split('|');

                if (valores.Length == 2)
                {
                    Function = valores[0].Trim(' ');
                    ValI = Convert.ToSingle(valores[1].Trim(' '));
                }
            }
        }

        [RelayCommand]
        public async Task CalcularAsync()
        {
            string response = await _dataServices.EnviarDatosAsync(11, string.Empty, string.Empty, Function, 0, 0, ValI);
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
