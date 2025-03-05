namespace zad1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void animalsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item.ToString() == "Pies")
            {
                slider.Maximum = 20;
            }
        }
    }

}
