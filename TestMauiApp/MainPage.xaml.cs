namespace TestMauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterBtn.Text = TestLibrary.TestLibrary.TestFunc();
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}