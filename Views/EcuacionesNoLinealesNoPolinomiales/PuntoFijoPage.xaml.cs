using CodexGigas.ViewModels.EcuacionesNoLinealesNoPolinomiales;

namespace CodexGigas.Views.EcuacionesNoLinealesNoPolinomiales;

public partial class PuntoFijoPage : ContentPage
{
	public PuntoFijoPage(PuntoFijoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}