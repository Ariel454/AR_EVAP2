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
        RadioButton1.CheckedChanged += RadioButton_CheckedChanged;
        RadioButton2.CheckedChanged += RadioButton_CheckedChanged;
        RadioButton3.CheckedChanged += RadioButton_CheckedChanged;

    }


    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton radioButton && radioButton.IsChecked)
        {
            TextoMostrarLabel.Text = ((StackLayout)radioButton.Parent).Children
                .OfType<Label>()
                .FirstOrDefault()
                ?.Text;
        }
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
    }


}