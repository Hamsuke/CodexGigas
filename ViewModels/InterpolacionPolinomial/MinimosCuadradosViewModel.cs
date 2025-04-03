using System.Net.Http.Json;
using System.Text.Json.Serialization;
using CodexGigas.Services;
using Newtonsoft.Json;

namespace CodexGigas.ViewModels.InterpolacionPolinomial;

[QueryProperty(nameof(Funcion), "funcion")]
public partial class MinimosCuadradosViewModel(IDataServices dataServices) : BaseViewModel
{
    private readonly IDataServices _dataServices = dataServices;
    [ObservableProperty]
    private string _funcion;

    [ObservableProperty]
    private string _x;

    [ObservableProperty]
    private string _y;

    [ObservableProperty]
    private string _ansa;

    [ObservableProperty]
    private string _ansb;

    [ObservableProperty]
    private string _fx;

    [RelayCommand]
    public void SetValores()
    {
        if (!string.IsNullOrWhiteSpace(Funcion) && Funcion.Contains('|'))
        {
            string[] valores = Funcion.Split('|');

            if (valores.Length == 2)
            {
                X = valores[0].Trim(' ', '(', ')', 'x');
                Y = valores[1].Trim(' ', '(', ')', 'y');
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
        else {
            dynamic ans = JsonConvert.DeserializeObject(response);
            _ansa = ans.resultado.a;
            _ansb = ans.resultado.b;
            _fx = ans.resultado.equation;
        }

    }
}
