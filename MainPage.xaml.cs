using Plugin.NFC;

namespace matrix_mess_less;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		CrossNFC.Current.OnMessageReceived += Current_OnMessageReceived;
	}

    private void Current_OnMessageReceived(ITagInfo tagInfo)
    {
		this.CounterBtn.Text = "Tag received: " + Convert.ToBase64String(tagInfo.Identifier);

		var records = tagInfo.Records;
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		CrossNFC.Current.StartListening();
	}
}

