using MauiMVVMDemoApp.ViewModels;

namespace MauiMVVMDemoApp.Views;
public partial class MainView : ContentPage
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}