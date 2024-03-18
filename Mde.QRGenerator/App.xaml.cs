using System.Diagnostics;



namespace Mde.QRGenerator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CreatePage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Created += Window_Created;
            window.Activated += Window_Activated;
            window.Deactivated += Window_Deactivated;
            window.Resumed += Window_Resumed;
            window.Destroying += Window_Destroying;

            return window;
        }

        private void Window_Created(object sender, EventArgs e)
        {
            Debug.WriteLine("App meets world (CREATED)");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Debug.WriteLine("App is now active (ACTIVATED)");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("App is going on a holiday (DEACTIVATED)");
        }

        private void Window_Resumed(object sender, EventArgs e)
        {
            Debug.WriteLine("App is back from holiday (RESUMED)");
        }

        private void Window_Destroying(object sender, EventArgs e)
        {
            Debug.WriteLine("App is being destroyed (DESTROYING)");
        }

    }
}
