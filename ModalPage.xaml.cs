using CommunityToolkit.Maui.Alerts;

namespace SnackbarSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var snackbar = Snackbar.Make($"Hi hi");
            snackbar.Show();

        }
    }
}