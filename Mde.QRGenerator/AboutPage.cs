namespace Mde.QRGenerator;

public class AboutPage : ContentPage
{
	public AboutPage()
	{
		Title = "About";
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { 
					HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					Text = "This app generates Quick Response codes!"
                }
			}
		};
	}
}