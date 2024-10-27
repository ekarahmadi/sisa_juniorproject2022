using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SISA.Views
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtName.Focus();
        }

        private void boxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(boxName.Text) && boxName.Text.Length > 0)
            {
                txtName.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtName.Visibility = Visibility.Visible;
            }
        }

        private void txtUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void boxUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(boxUsername.Text) && boxUsername.Text.Length > 0)
            {
                txtUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtUsername.Visibility = Visibility.Visible;
            }
        }

        //private void txtRole_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    txtRole.Focus();
        //}

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            boxRole.Items.Add("Admin");
            boxRole.Items.Add("TPS Manager");
            boxRole.Items.Add("Waste Manager");
        }

        private void txtPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void boxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(boxPassword.Password) && boxPassword.Password.Length > 0)
            {
                txtPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtPassword.Visibility = Visibility.Visible;
            }
        }
    }
}
