namespace ListViewItems
{
    public partial class MainPage : ContentPage
    {
        public List<string> Names { get; set; } = new List<string>();
        public MainPage()
        {
           
            for (int i = 0; i < 50; i++)
            {
                Names.Add (i.ToString());
            }
            BindingContext = this;

            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item Selected", 
                "Item =" + e.SelectedItem.ToString() +
                " Index = " + e.SelectedItemIndex.ToString(), "OK");
        }
    }

}
