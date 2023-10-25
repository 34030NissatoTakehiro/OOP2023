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

namespace GridLayoutSample {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void checkbox_Checked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "チェック済み";
        }

        private void chackBox_Unchacked(object sender, RoutedEventArgs e) {
            checkBoxTextBlock.Text = "未チェック";

        }

        private void redRadioBotton_Checked(object sender, RoutedEventArgs e) {
            colorTextBlock.Text = "赤";
        }

        private void yellowRadioBotton_Checked(object sender, RoutedEventArgs e) {
            colorTextBlock.Text = "黄";

        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e) {
            colorTextBlock.Text = "青";

        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            sesonTextBlock.Text = (string)((ComboBoxItem)(seasonComboBox.SelectedItem)).Content;
        }
    }
}
