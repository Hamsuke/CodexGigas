namespace CodexGigas.ViewModels;

public partial class EcuacionesDiferencialesOrdinariasParcialesViewModel : BaseViewModel
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
            1 => "",
            2 => "",
            3 => "RungeKuttaOrden2Page",
            5 => "",
            7 => "",
            8 => "",
            9 => "",
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
