using CodexGigas.Model;

namespace CodexGigas.ViewModels;

public partial class InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel : BaseViewModel
{

    public ObservableCollection<MetodoModels> Metodos1014 { get; set; }
    public InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel()
    {
        Metodos1014 = [

            new () { Id = 10, Name = "Vandermonde" },
            new () { Id = 11, Name = "Interpolacion de Newton" },
            new () { Id = 12, Name = "Interpolacion Baricentrica (Lagrange)" },
            new () { Id = 13, Name = "Minimos Cuadrados" },
            new () { Id = 14, Name = "Polinomios Ortogonales de Chebyshev" },
        ];

    }
}
