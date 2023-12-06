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

        
        int numbersCount = CountNumbers(inputText);
        int lettersCount = CountLetters(inputText);
       
        lblNumbers.Text = $"Números: {numbersCount}";
        lblLetters.Text = $"Letras: {lettersCount}";
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        txtInput.Text = string.Empty;
        lblNumbers.Text = string.Empty;
        lblLetters.Text = string.Empty;
    }

    private int CountNumbers(string text)
    {
        return text.Count(char.IsDigit);
    }

    private int CountLetters(string text)
    {
        return text.Count(char.IsLetter);
    }

}
