using Microsoft.Extensions.DependencyInjection;
using appUsadoTabbedPage_45756121.Views;
namespace appUsadoTabbedPage_45756121
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Principal());
        }
    }
}