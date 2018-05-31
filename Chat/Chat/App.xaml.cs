using Xamarin.Forms;
using PCLAppConfig;
using System.Reflection;
using Chat.Interfaces;
using Chat.Services;

namespace Chat
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //RegistrandoDependencias
            DependencyService.Register<IAlertService, AlertService>();

            //Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            //ConfigurationManager.Initialise(assembly.GetManifestResourceStream("Chat.App.config"));

            MainPage = new Views.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
