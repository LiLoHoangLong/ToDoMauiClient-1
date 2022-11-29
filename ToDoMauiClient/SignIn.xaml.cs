namespace ToDoMauiClient;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
        InitializeComponent();
    }
    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");

        //await DisplayAlert("Alert", "You have been alerted", "OK");
    }
}