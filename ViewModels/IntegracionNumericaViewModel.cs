using CodexGigas.Model;

namespace CodexGigas.ViewModels;

public partial class IntegracionNumericaViewModel : BaseViewModel
{
    public ObservableCollection<MetodoModels> Metodos1523 { get; set; }

    public IntegracionNumericaViewModel()
    {
        Metodos1523 = new ObservableCollection<MetodoModels>
        {
            new MetodoModels { Id = 15, Name = "Formula cerrada de Newton - Cotes N = 1" },
            new MetodoModels { Id = 16, Name = "Formula cerrada de Newton - Cotes N = 2" },
            new MetodoModels { Id = 17, Name = "Formula cerrada de Newton - Cotes N = 3" },
            new MetodoModels { Id = 18, Name = "Formula abierta de Newton - Cotes N = 1" },
            new MetodoModels { Id = 19, Name = "Formula abierta de Newton - Cotes N = 2" },
            new MetodoModels { Id = 20, Name = "Formula abierta de Newton - Cotes N = 3" },
            new MetodoModels { Id = 21, Name = "Formula de integracion de Romberg" },
            new MetodoModels { Id = 22, Name = "Cuadraturas de Gauss - Legendre N = 2" },
            new MetodoModels { Id = 23, Name = "Cuadraturas de Gauss - Legendre N = 3" }
        };
    }
}
