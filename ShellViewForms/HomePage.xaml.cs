
using Xamarin.Forms;

namespace ShellViewForms
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void NavigateButton_Clicked(object sender, System.EventArgs e)
        {
            (Application.Current.MainPage as Shell).GoToAsync($"ragu:///myshellview/secondpage", true);
        }

        void OpenMenuButton_Clicked(object sender, System.EventArgs e)
        {
            (Application.Current.MainPage as Shell).FlyoutIsPresented = true;
        }
    }
}
