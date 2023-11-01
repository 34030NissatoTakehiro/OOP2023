using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChacker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rslider.Value, (byte)gslider.Value, (byte)bslider.Value);
            SolidColorBrush Bur = new SolidColorBrush(color);
            coloArea.Background = Bur;
        }
        private void StockButton_Click(object sender, RoutedEventArgs e) {

            string stok = String.Format("R {0} G {1} B {2}",rslider.Value,gslider.Value,bslider.Value);
            Stock.Items.Add(stok);
        }
        private void Stock_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] Click = Stock.SelectedItem.ToString().Split(' ');
            rLabel.Text = Click[1];
            gLabel.Text = Click[3];
            bLabel.Text = Click[5];
        }


        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            SolidColorBrush Bur = new SolidColorBrush();
            var comboColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = comboColor.Color;
            rslider.Value = color.R;
            gslider.Value = color.G;
            bslider.Value = color.B;

            Bur.Color = comboColor.Color;
            coloArea.Background = Bur;
        }

      
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
