namespace CodexGigas.Views;

public partial class EcuacionesPolinomialesPage : ContentPage
{
	public EcuacionesPolinomialesPage(EcuacionesPolinomialesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            EntryPolinomio.Text += button.Text; // Agrega el texto del botón al Entry
        }
    }

    private void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(EntryPolinomio.Text))
        {
            EntryPolinomio.Text = EntryPolinomio.Text.Substring(0, EntryPolinomio.Text.Length - 1);
        }
    }

}
