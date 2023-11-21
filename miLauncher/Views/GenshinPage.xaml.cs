using Microsoft.UI.Xaml.Controls;

using miLauncher.ViewModels;

namespace miLauncher.Views;

public sealed partial class GenshinPage : Page
{
    public GenshinViewModel ViewModel
    {
        get;
    }

    public GenshinPage()
    {
        ViewModel = App.GetService<GenshinViewModel>();
        InitializeComponent();
    }
}
