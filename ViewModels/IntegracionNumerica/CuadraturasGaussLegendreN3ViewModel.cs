namespace CodexGigas.ViewModels.IntegracionNumerica
{
    [QueryProperty(nameof(Funcion), "funcion")]
    public partial class CuadraturasGaussLegendreN3ViewModel : BaseViewModel
    {
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
                    Liminf = valores[1].Trim(' ', '(', ')', 'y', 'x');
                    Limsup = valores[2].Trim(' ', '(', ')', 'y', 'x');
                }
            }
        }
    }
}
