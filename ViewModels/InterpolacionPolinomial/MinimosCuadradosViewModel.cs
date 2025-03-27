namespace CodexGigas.ViewModels.InterpolacionPolinomial;

[QueryProperty(nameof(Funcion), "funcion")]
public partial class MinimosCuadradosViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _funcion;

    [ObservableProperty]
    private string _x;

    [ObservableProperty]
    private string _y;

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
}
