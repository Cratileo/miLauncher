using Microsoft.UI.Xaml.Controls;

using miLauncher.ViewModels;

namespace miLauncher.Views;

public sealed partial class CheckPage : Page
{
    public CheckViewModel ViewModel
    {
        get;
    }

    public CheckPage()
    {
        ViewModel = App.GetService<CheckViewModel>();
        InitializeComponent();
    }
}
