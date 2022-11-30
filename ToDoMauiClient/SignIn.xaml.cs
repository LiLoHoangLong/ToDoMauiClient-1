//using Org.Apache.Http.Authentication;

namespace ToDoMauiClient;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
        InitializeComponent();
    }
    //private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync("//SignUp");

    //}

    public void Login_Clicked(object sender, EventArgs e)
    {
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        if(Email == null || Password == null)
        {
            DisplayAlert("Waring", "Please Input Email & Password","Ok");
            return;
        }
    }
}