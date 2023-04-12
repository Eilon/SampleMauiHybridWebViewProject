namespace SampleMauiHybridWebViewProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnHybridWebViewRawMessageReceived(object sender, HybridWebView.HybridWebViewRawMessageReceivedEventArgs e)
    {
        await Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("JavaScript message", e.Message, "OK");
        });
    }
}

