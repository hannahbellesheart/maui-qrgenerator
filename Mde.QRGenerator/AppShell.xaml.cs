namespace Mde.QRGenerator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void SiteLink_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.howest.be/en");
        }
    }
}
