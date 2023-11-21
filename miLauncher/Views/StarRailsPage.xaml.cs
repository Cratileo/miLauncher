using Microsoft.UI.Xaml.Controls;

using miLauncher.ViewModels;

namespace miLauncher.Views;

public sealed partial class StarRailsPage : Page
{
    public StarRailsViewModel ViewModel
    {
        get;
    }

    public StarRailsPage()
    {
        ViewModel = App.GetService<StarRailsViewModel>();
        InitializeComponent();
    }
}
