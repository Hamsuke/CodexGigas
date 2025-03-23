namespace CodexGigas.Views;

public partial class EcuacionesNoLinealesNoPolinomialesPage : ContentPage
{
	public EcuacionesNoLinealesNoPolinomialesPage(EcuacionesNoLinealesNoPolinomialesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
