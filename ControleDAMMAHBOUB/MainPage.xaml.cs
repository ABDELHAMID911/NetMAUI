namespace ControleDAMMAHBOUB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (entry.Text=="DAM2024")
            {
                count++;
                this.Navigation.PushAsync(new Bravo(count));
                
                
            }
            else
            {
                DisplayAlert("Alert", "password invalid", "OK");
            }
            
        }
        public int Count
        {
            get { return count; }
            set { count = value; } 
        }
    }

}
