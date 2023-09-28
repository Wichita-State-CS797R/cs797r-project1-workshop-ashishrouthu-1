namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public MainPage(MonkeysViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
