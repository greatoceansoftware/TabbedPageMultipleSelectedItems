namespace MAUI_Non_Shell_App;

public partial class Portfolio : ContentPage
{
  public Portfolio()
  {
    InitializeComponent();
  }

  private void ButtonProject1_Clicked(object sender, EventArgs e)
  {
    Navigation.PushAsync(new Project());
  }
}