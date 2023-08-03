using Pathfinder.ViewModel;

namespace Pathfinder
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }
}