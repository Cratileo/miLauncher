using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using miLauncher.ViewModels;
using Windows.Storage.Pickers;

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

    private async void PickAFileButton_Click(object sender, RoutedEventArgs e)
    {
        // Clear previous returned file name, if it exists, between iterations of this scenario
        // OutputTextBlock.Text = "";

        // Create a file picker
        var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

        // Retrieve the window handle (HWND) of the current WinUI 3 window.
        //TODO: Repeair it by Finding WindowsHelper.cs on WinUI3 source code
        // var window = WindowHelper.GetWindowForElement(this);
        var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

        // Initialize the file picker with the window handle (HWND).
        WinRT.Interop.InitializeWithWindow.Initialize(openPicker, hWnd);

        // Set options for your file picker
        openPicker.ViewMode = PickerViewMode.Thumbnail;
        openPicker.FileTypeFilter.Add("*");

        // Open the picker for the user to pick a file
        var file = await openPicker.PickSingleFileAsync();
        if (file != null)
        {
            PickAFileOutputTextBlock.Text = "Picked file: " + file.Name;
        }
        else
        {
            PickAFileOutputTextBlock.Text = "Operation cancelled.";
        }
    }
}
