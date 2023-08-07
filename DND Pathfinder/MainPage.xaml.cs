using DND_Pathfinder.ViewModels;

namespace DND_Pathfinder
{
	public partial class MainPage : ContentPage
	{
		private MainViewModel _viewModel;

		public MainPage()
		{
			_viewModel = new MainViewModel(null);
			InitializeComponent();
		
			BindingContext = _viewModel;
		}
	}
}