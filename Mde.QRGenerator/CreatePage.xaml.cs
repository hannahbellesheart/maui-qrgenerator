namespace Mde.QRGenerator;

public partial class CreatePage : ContentPage
{
	public CreatePage()
	{
		InitializeComponent();
	}

    private async void btnCreate_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//qr/generate?qrcontent={txtInput.Text}");
    }

}