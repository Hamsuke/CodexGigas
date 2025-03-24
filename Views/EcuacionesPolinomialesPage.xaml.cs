namespace CodexGigas.Views;

public partial class EcuacionesPolinomialesPage : ContentPage
{
	public EcuacionesPolinomialesPage(EcuacionesPolinomialesViewModel viewModel)
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

    private void OnDecimalClicked(object sender, EventArgs e)
    {
        if (!input.Contains("."))  // Evita agregar más de un punto decimal
        {
            input += ".";
            EntryPolinomio.Text = input;
        }
    }

    private void OnParenthesisClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            input += button.Text;
            EntryPolinomio.Text = input;
        }
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

    // Maneja el botón "Enter" (Evaluar la expresión ingresada)
    private void OnEnterClicked(object sender, EventArgs e)
    {
        try
        {
            double resultado = EvaluarExpresion(input);
            EntryPolinomio.Text = resultado.ToString();
            input = resultado.ToString();
        }
        catch (Exception)
        {
            EntryPolinomio.Text = "Error";
            input = "";
        }
    }

    // Método para evaluar la expresión matemática ingresada
    private double EvaluarExpresion(string expresion)
    {
        // Convertir la expresión en un cálculo (debes usar una librería o escribir tu propio parser)
        // Esto es un ejemplo usando System.Data.DataTable
        var dt = new System.Data.DataTable();
        return Convert.ToDouble(dt.Compute(expresion, ""));
    }

}
