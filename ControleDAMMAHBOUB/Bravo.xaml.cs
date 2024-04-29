
namespace ControleDAMMAHBOUB;

public partial class Bravo : ContentPage
{
    MainPage num = new MainPage();
    public Bravo(int a)
    {
        InitializeComponent();
        myLabel.Text = "PASSWORD CORRCT : "+a.ToString();
    }

    
}

    