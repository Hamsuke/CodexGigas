using CodexGigas.ViewModels.InterpolacionPolinomial;

namespace CodexGigas.Views;

public partial class MinimosCuadradosPages : ContentPage
{
	public MinimosCuadradosPages(MinimosCuadradosViewModel minimosCuadrados)
	{

		InitializeComponent();
		BindingContext = minimosCuadrados;

	}
}