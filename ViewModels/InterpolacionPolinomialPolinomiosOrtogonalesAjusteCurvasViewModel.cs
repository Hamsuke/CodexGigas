namespace CodexGigas.ViewModels;
    public partial class InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel : BaseViewModel
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
                0 => "VanderMondePages",
                1 => "InterDeNewtonPages",
                2 => "InterBariLagraPages",
                3 => "MinimosCuadradosPages",
                4 => "PoliOrtoDeChebyPages",
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
