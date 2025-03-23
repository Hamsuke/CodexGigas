namespace CodexGigas.Views;

public partial class EcuacionesDiferencialesOrdinariasParcialesPage : ContentPage
{
	public EcuacionesDiferencialesOrdinariasParcialesPage(EcuacionesDiferencialesOrdinariasParcialesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
