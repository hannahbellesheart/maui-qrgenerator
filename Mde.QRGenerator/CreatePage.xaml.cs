namespace Mde.QRGenerator;

public partial class CreatePage : ContentPage
{
    private Color selectedColor = Colors.Black;

    public CreatePage()
	{
		InitializeComponent();
	}

    private async void btnCreate_Clicked(object sender, EventArgs e)
    {
        var data = new QRCodeData
        {
            Content = txtInput.Text,
            FillColor = selectedColor
        };
        var parameter = new Dictionary<string, object>
        {
            { "qrdata", data }
        };

        await Shell.Current.GoToAsync("//qr/generate", parameter);
    }

    private void OnColorChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = (RadioButton)sender;
        var colorHex = (string)radioButton.Value;
        if (radioButton.IsChecked)
        {
            selectedColor = Color.FromArgb(colorHex);
        }
    }
}