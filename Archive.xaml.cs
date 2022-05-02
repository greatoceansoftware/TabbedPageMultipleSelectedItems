namespace MAUI_Non_Shell_App;

public partial class Archive : ContentPage
{
  public Archive()
  {
    InitializeComponent();
  }

  private void ButtonArchive1_Clicked(object sender, EventArgs e)
  {
    Navigation.PushAsync(new Project());
  }
}