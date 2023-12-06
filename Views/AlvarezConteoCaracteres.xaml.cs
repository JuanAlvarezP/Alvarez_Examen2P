namespace Alvarez_AppApuntes.Views;

public partial class AlvarezConteoCaracteres : ContentPage
{
	public AlvarezConteoCaracteres()
	{
		InitializeComponent();
	}

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        string inputText = txtInput.Text;

        // Realizar cálculos
        int numbersCount = CountNumbers(inputText);
        int lettersCount = CountLetters(inputText);
        int vowelsCount = CountVowels(inputText);
        int upperCaseCount = CountUpperCase(inputText);
        int lowerCaseCount = CountLowerCase(inputText);
        int totalCount = inputText.Length;

        // Actualizar las etiquetas con los resultados
        Alvarez_Numeros.Text = $"Números: {numbersCount}";
        Alvarez_Letras.Text = $"Letras: {lettersCount}";
        Alvarez_Vocales.Text = $"Vocales: {vowelsCount}";
        Alvarez_Mayus.Text = $"Mayúsculas: {upperCaseCount}";
        Alvarez_Minus.Text = $"Minúsculas: {lowerCaseCount}";
        Alvarez_Total.Text = $"Total: {totalCount}";

        // Mostrar el layout de resultados
        Resultados.IsVisible = true;
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        // Limpiar campos y ocultar el layout de resultados
        txtInput.Text = string.Empty;
        Alvarez_Numeros.Text = string.Empty;
        Alvarez_Letras.Text = string.Empty;
        Alvarez_Vocales.Text = string.Empty;
        Alvarez_Mayus.Text = string.Empty;
        Alvarez_Minus.Text = string.Empty;
        Alvarez_Total.Text = string.Empty;

        Resultados.IsVisible = false;
    }

    // Métodos para realizar los cálculos
    private int CountNumbers(string text)
    {
        return text.Count(char.IsDigit);
    }

    private int CountLetters(string text)
    {
        return text.Count(char.IsLetter);
    }

    private int CountVowels(string text)
    {
        return text.Count(c => "AEIOUaeiou".Contains(c));
    }

    private int CountUpperCase(string text)
    {
        return text.Count(char.IsUpper);
    }

    private int CountLowerCase(string text)
    {
        return text.Count(char.IsLower);
    }
}
