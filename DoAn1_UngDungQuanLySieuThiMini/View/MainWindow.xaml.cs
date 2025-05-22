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



namespace DoAn1_UngDungQuanLySieuThiMini.View
{
    public partial class MainWindow : Window
    {

        #region Declare Constructors
        public MainWindow()
        {
            InitializeComponent();
        }


        #endregion

        #region Declare NavigateBar

        private void NavToDashboard_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NavToNhanVien_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NavToSanPham_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NavToNhapHang_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void NavToBaoCao_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MenuButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Handle UIevent
        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void TextBoxSearching_OnKeyDown(object sender, KeyEventArgs e)
        {

        }
        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBoxSearching.Text != string.Empty)
            {
                TextBlockPlaceHolder.Visibility = Visibility.Hidden;
            }
            else
            {
                TextBlockPlaceHolder.Visibility = Visibility.Visible;
            }
        }

        private void SearchTextContainer_OnGotFocus(object sender, RoutedEventArgs e)
        {
            SearchTextContainer.BorderBrush = Brushes.CornflowerBlue;
        }

        private void SearchTextContainer_OnLostFocus(object sender, RoutedEventArgs e)
        {
            SearchTextContainer.BorderBrush = Brushes.Black;
        }
        #endregion

    }

}
