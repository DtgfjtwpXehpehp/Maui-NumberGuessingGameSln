namespace GuessingGame;

public partial class GuessingGamePage : ContentPage
{
	private int numberToGuess;
	public GuessingGamePage(int minimum, int maximum)
	{
		InitializeComponent();


		Random random = new Random();

		numberToGuess = random.Next(minimum,maximum);

        feedbackLabel.Text = $"Guess a number between {minimum} and {maximum}";

    }

    private void guessButton_Clicked(object sender, EventArgs e)
    {
		int numberGuessed = int.Parse(guessingEntry.Text);


        if (numberGuessed == numberToGuess)
        {
            feedbackLabel.Text = "Well done! Correct Guess";

        }
        else if (numberGuessed > numberToGuess)
		{
            feedbackLabel.Text = "Too High";

        }
        else
        {
            feedbackLabel.Text = "Too Low";

        }
    }
}