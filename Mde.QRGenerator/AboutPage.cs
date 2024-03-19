namespace Mde.QRGenerator;

public class AboutPage : ContentPage
{
	public AboutPage()
	{
		Title = "About";
		Content = new VerticalStackLayout
		{
			VerticalOptions = LayoutOptions.Center,
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