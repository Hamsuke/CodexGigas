namespace CodexGigas.Views;

public partial class IntegracionNumericaPage : ContentPage
{
	public IntegracionNumericaPage(IntegracionNumericaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private string input = "";  // Guarda la entrada del usuario

    // Maneja clics en botones numéricos (0-9)
    private void OnNumberClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += button.Text;
            EntryPolinomio.Text = input;
        }
    }

    private void OnSeparatorClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += "|";
            EntryPolinomio.Text = input;
        }
    }

    private void OnDecimalClicked(object sender, EventArgs e)
    {
        input += ".";
        EntryPolinomio.Text = input;
    }


    private void OnComaClicked(object sender, EventArgs e)
    {
        input += ",";
        EntryPolinomio.Text = input;
    }

    private void OnParenthesisClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += button.Text;
            EntryPolinomio.Text = input;
        }
    }

    private void OnPotenciaClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += "^";
            EntryPolinomio.Text = input;
        }
    }

    private void OnPiClicked(object sender, EventArgs e)
    {
        input += Math.PI;
        EntryPolinomio.Text = input;
    }

    private void OnFunctionClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += button.Text + "(";
            EntryPolinomio.Text = input;
        }
    }

    // Maneja clics en operadores (+, -, *, /)
    private void OnOperatorClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input += " " + button.Text + " ";
                EntryPolinomio.Text = input;
            }
        }
    }

    // Maneja el botón "⌫" (Borrar un carácter)
    private void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (input.Length > 0)
        {
            input = input.Substring(0, input.Length - 1);
            EntryPolinomio.Text = input;
        }
    }

    // Maneja el botón "Limpiar" (Borrar todo)
    private void OnClearClicked(object sender, EventArgs e)
    {
        input = "";
        EntryPolinomio.Text = "";
    }
}
