namespace HomeTcc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnToggleMenu(object sender, EventArgs e)
    {
        MenuSuspenso.IsVisible = !MenuSuspenso.IsVisible;
        ConteudoPrincipal.IsVisible = !ConteudoPrincipal.IsVisible;
    }


}
