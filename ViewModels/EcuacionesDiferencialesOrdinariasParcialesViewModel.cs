using CodexGigas.Model;

namespace CodexGigas.ViewModels;

public partial class EcuacionesDiferencialesOrdinariasParcialesViewModel : BaseViewModel
{
    public ObservableCollection<MetodoModels> Metodos2432 { get; set; }
    public EcuacionesDiferencialesOrdinariasParcialesViewModel()
    {
        Metodos2432 = [
            new () { Id = 0, Name = "<--------Metodos de un paso-------->" },
            new() { Id = 24, Name = "Euler" },
            new () { Id = 25, Name = "Euler - Cauchy (regla trapeizodal)" },
            new () { Id = 26, Name = "Runge - Kutta (euler modificado)" },
            new () { Id = 27, Name = "Runge - Kutta [Orden 2]" },
            new () { Id = 0, Name = "<--------Metodos Multipaso--------->" },
            new () { Id = 28, Name = "Metodo Predictor - Corrector Correctos iterativo para M = 0" },
            new () { Id = 0, Name = "<--------Sistemas de ecuaciones diferenciales-------->" },
            new () { Id = 29, Name = "Euler" },
            new () { Id = 30, Name = "Euler - Cauchy (regla trapeizodal)" },
            new () { Id = 31, Name = "Runge - Kutta (euler modificado)" },
            new () { Id = 32, Name = "Runge - Kutta [Orden 2]" },
        ];

    }
}
