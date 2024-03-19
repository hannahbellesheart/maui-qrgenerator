namespace Mde.QRGenerator;

[QueryProperty(nameof(Input), "qrcontent")]
public partial class ViewQRPage : ContentPage
{
	public ViewQRPage()
	{
		InitializeComponent();
    }
    public string Input
    {
        set
        {
            lblContent.Text = value;
            barcodeGenerator.Value = value;
        }
    }

}