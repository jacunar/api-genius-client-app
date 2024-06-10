using APIGeniusClientLibrary;

namespace APIGeniusClientUI; 
public partial class MainForm : Form {
    private readonly IAPIAccess api = new APIAccess();

    public MainForm() {
        InitializeComponent();
    }

    private async void CallAPIButton_Click(object sender, EventArgs e) {
        SystemStatusLabel.Text = "Calling API...";
        ResultTextBox.Text  = string.Empty;

        if (!api.IsValidUrl(ApiUrlTextBox.Text)) {
            SystemStatusLabel.Text = "Invalid URL";
            return;
        }

        try {
            ResultTextBox.Text = await api.CallApiAsync(ApiUrlTextBox.Text);            

            SystemStatusLabel.Text = "Ready";
        } catch (Exception ex) {
            ResultTextBox.Text = "An error ocurred: " + ex.Message;
            SystemStatusLabel.Text = "Error";
        }
    }
}
