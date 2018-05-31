using Chat.ViewsModels;
using Xamarin.Forms;

namespace Chat.Views
{
	public partial class MainPage : ContentPage
	{
        MainViewModel viewModel;

		public MainPage()
		{
			InitializeComponent();
            BindingContext = viewModel = new MainViewModel();
		}
	}
}
