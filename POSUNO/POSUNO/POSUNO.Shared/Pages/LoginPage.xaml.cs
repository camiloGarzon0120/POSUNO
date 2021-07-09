using POSUNO.Helpers;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace POSUNO.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = await ValidForm();
            if(!isValid)
            {
                return;
            }

            MessageDialog messageDialog = new MessageDialog("Vamos bien", "Ok");
            await messageDialog.ShowAsync();

        }

        private async Task<bool> ValidForm()
        {

            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageDialog messageDialog = new MessageDialog("Debes ingresar tu email", "Error");
                await messageDialog.ShowAsync();
                return false;
            }

            if (!RegexUtilities.IsValidEmail(EmailTextBox.Text))
            {
                MessageDialog messageDialog = new MessageDialog("Debes ingresar un email valido", "Error");
                await messageDialog.ShowAsync();
                return false;
            }

            if (string.IsNullOrEmpty(PasswordPasswordBox.Password))
            {
                MessageDialog messageDialog = new MessageDialog("Debes ingresar tu contraseña", "Error");
                await messageDialog.ShowAsync();
                return false;
            }

            return true;
        }
    }
}
