namespace GuessingGame;

public partial class SliderDemoPage : ContentPage
{
	public SliderDemoPage()
	{
		InitializeComponent();

        DemoSlider.Minimum = 1;
        DemoSlider.Maximum = 360;
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var value = Math.Round(e.NewValue, 0);
        SliderValueLabel.Text = value.ToString();
        SliderValueLabel.FontSize = value;

        SlideMeLabel.Rotation = value;
    }
}