namespace Mde.QRGenerator;

[QueryProperty(nameof(Input), "qrdata")]
public partial class ViewQRPage : ContentPage
{
	public ViewQRPage()
	{
		InitializeComponent();
    }

    public QRCodeData Input
    {
        set
        {
            lblContent.Text = value.Content;
            barcodeGenerator.Value = value.Content;
            barcodeGenerator.ForegroundColor = value.FillColor;
        }
    }
}
