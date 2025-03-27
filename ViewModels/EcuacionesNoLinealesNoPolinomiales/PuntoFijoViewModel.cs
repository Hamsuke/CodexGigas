namespace CodexGigas.ViewModels.EcuacionesNoLinealesNoPolinomiales;

    [QueryProperty(nameof(Funcion), "funcion")]
    public partial class PuntoFijoViewModel : BaseViewModel
    {
    [ObservableProperty]
    private string _funcion;

    [ObservableProperty]
    private string _function;

    [ObservableProperty]
    private string _x0;

    [ObservableProperty]
    private string _y0;

    [ObservableProperty]
    private string _h;

    [ObservableProperty]
    private string _n;


    [RelayCommand]
    public void SetValores()
    {
        if (!string.IsNullOrWhiteSpace(Funcion) && Funcion.Contains('|'))
        {
            string[] valores = Funcion.Split('|');

            if (valores.Length == 2)
            {
                Function = valores[0].Trim(' ');
                X0 = valores[1].Trim(' ', '(', ')', 'y');
                Y0 = valores[2].Trim(' ', '(', ')', 'y');
                H = valores[3].Trim(' ', '(', ')', 'y');
                N = valores[4].Trim(' ', '(', ')', 'y');
            }
        }
    }
}
