namespace CodexGigas.ViewModels;

public partial class EcuacionesPolinomialesViewModel : BaseViewModel
{

    [ObservableProperty]
    private string _funcion;

    [ObservableProperty]
    private int _seleccion;

    [RelayCommand]
    public async Task Navegacion()
    {
#pragma warning disable CS8600 // Warning mugroso me tiene harto
        string ruta = Seleccion switch
        {
            0 => "BairstowPages",
            1 => "NewtonPages",
            _ => null
        };
#pragma warning restore CS8600 // Warning mugroso me tiene harto

        if (!string.IsNullOrEmpty(ruta))
        {
            // Enviar "funcion" como parámetro en la URL
            await Shell.Current.GoToAsync($"{ruta}?funcion={Funcion}");
        }
    }
}
