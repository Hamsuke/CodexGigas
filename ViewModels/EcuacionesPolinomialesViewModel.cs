using CodexGigas.Model;

namespace CodexGigas.ViewModels;

public partial class EcuacionesPolinomialesViewModel : BaseViewModel
{
    public ObservableCollection<MetodoModels> Metodos89 { get; set; }
    public EcuacionesPolinomialesViewModel()
    {
        Metodos89 = [

            new () { Id = 8, Name = "Bairstow" },
            new () { Id = 9, Name = "Newton" }
        ];

    }
}
