using CodexGigas.Model;

namespace CodexGigas.ViewModels;

public partial class EcuacionesNoLinealesNoPolinomialesViewModel : BaseViewModel
{
    public ObservableCollection<MetodoModels> Metodos17 { get; set; }
   public  EcuacionesNoLinealesNoPolinomialesViewModel()
    {
        Metodos17 = [

            new () { Id = 1, Name = "Biseccion" },
            new () { Id = 2, Name = "Regla Falsa" },
            new () { Id = 3, Name = "Secante" },
            new () { Id = 4, Name = "Newton - Raphson" },
            new () { Id = 5, Name = "Punto Fijo" },
            new () { Id = 6, Name = "Newton - Raphson Aplicado a Sistemas de Ecuaciones no Lineales" },
            new () { Id = 7, Name = "Punto Fijo Aplicado a Sistemas de Ecuaciones no Lineales" }
        ];

    }
}
