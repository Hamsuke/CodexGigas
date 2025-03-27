using System.Collections.ObjectModel;
using CodexGigas.ViewModels;

namespace CodexGigas.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    public int _seleccion;
}
