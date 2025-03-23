namespace CodexGigas.Views;

public partial class InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasPage : ContentPage
{
	public InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasPage(InterpolacionPolinomialPolinomiosOrtogonalesAjusteCurvasViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
