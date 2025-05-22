using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Shapes;
using DoAn1_UngDungQuanLySieuThiMini.View;

namespace DoAn1_UngDungQuanLySieuThiMini.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        #region Declare attributes
        private readonly BitmapImage _showPwdIcon = new BitmapImage(new Uri("pack://application:,,,/Assets/Icon/showpwdIcon.png"));
        private readonly BitmapImage _hidePwdIcon = new BitmapImage(new Uri("pack://application:,,,/Assets/Icon/hidepwdIcon.png"));
        private bool _isShowPassword;
        private int _userId;
        #endregion

        #region Declare Constructors
        public LoginWindow()
        {
            InitializeComponent();
            _isShowPassword = false;

        }

        #endregion

        #region Login Handlers

        private void LoginBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Login();
        }



        private void Login()
        {
            ResetPasswordWindow window = new ResetPasswordWindow();
            window.Show();
            Hide();

        }


        #endregion

        #region Handle UI Event

        private void ShowPassWordBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_isShowPassword)
            {
                VisiblePasswordBox.Visibility = Visibility.Visible;
                PasswordBox.Visibility = Visibility.Collapsed;
                ShowPassWordIcon.Source = _showPwdIcon;
                VisiblePasswordBox.Text = PasswordBox.Password;
                _isShowPassword = true;
            }
            else
            {
                VisiblePasswordBox.Visibility = Visibility.Collapsed;
                PasswordBox.Visibility = Visibility.Visible;
                ShowPassWordIcon.Source = _hidePwdIcon;
                PasswordBox.Password = VisiblePasswordBox.Text;
                _isShowPassword = false;
            }
        }

        private void BoxBorder_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is Border bd)
            {
                bd.BorderBrush = Brushes.CornflowerBlue;
            }
        }

        private void BoxBorder_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is Border bd)
            {
                bd.BorderBrush = Brushes.Black;

            }
        }


        private void LoginWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }

        private void ForgotPassword_OnClick(object sender, RoutedEventArgs e)
        {
            ResetPasswordWindow window = new ResetPasswordWindow();
            window.Show();
            Hide();
        }


        #endregion

    }

}
