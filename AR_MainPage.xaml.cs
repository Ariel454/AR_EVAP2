namespace AR_EVAP2;

public partial class AR_MainPage : ContentPage
{
	public AR_MainPage()
	{
		InitializeComponent();

        List<string> elementos = new List<string>
        {
            "Movistar",
            "Claro",
            "Cnt"
        };

        ElementPicker.ItemsSource = elementos;
    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");

    }
    private void OnButtonClicked(object sender, EventArgs e)
    {
        ElementPicker.Focus();
    }

    private void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        var selectedElement = ElementPicker.SelectedItem as string;
        ElementEntry.Text = selectedElement;
    }


}