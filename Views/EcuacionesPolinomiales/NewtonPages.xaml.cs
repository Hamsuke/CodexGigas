using CodexGigas.ViewModels.EcuacionesPolinomiales;

namespace CodexGigas.Views.EcuacionesPolinomiales;

public partial class NewtonPages : ContentPage
{
	public NewtonPages(NewtonViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}