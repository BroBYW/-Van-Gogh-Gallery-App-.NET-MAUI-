namespace Progress_Test
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnReadMoreTapped(object sender, EventArgs e)
        {
            if (BindingContext is ViewModels.ProfileViewModel vm)
            {
                vm.IsBioExpanded = !vm.IsBioExpanded;
            }
        }
    }
}
