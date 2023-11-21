using Microsoft.UI.Xaml.Controls;

using miLauncher.ViewModels;

namespace miLauncher.Views;

public sealed partial class HonKai3Page : Page
{
    public HonKai3ViewModel ViewModel
    {
        get;
    }

    public HonKai3Page()
    {
        ViewModel = App.GetService<HonKai3ViewModel>();
        InitializeComponent();
    }
}
