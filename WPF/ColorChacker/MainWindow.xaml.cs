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
        List<MyColor> colors = new List<MyColor>(); 
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rslider.Value, (byte)gslider.Value, (byte)bslider.Value);
            SolidColorBrush Bur = new SolidColorBrush(color);
            coloArea.Background = Bur;
        }
        private void StockButton_Click(object sender, RoutedEventArgs e) {
            Color color = Color.FromRgb((byte)rslider.Value, (byte)gslider.Value, (byte)bslider.Value);
            var getlist =GetColorList();
             var colooo = getlist.FirstOrDefault(x=> x.Color == color)?.Name?? String.Format("R {0} G {1} B {2}", rslider.Value, gslider.Value, bslider.Value);
            colors.Add(new MyColor {Color = color,Name= colooo });
            
            Stock.Items.Add(colooo);
        }
        private void Stock_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectChange = Stock.SelectedItem;
            var tansaku = colors.Find(x => x.Name == selectChange.ToString());
            rLabel.Text = tansaku.Color.R.ToString();
            gLabel.Text = tansaku.Color.G.ToString();
            bLabel.Text = tansaku.Color.B.ToString();
            
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

        private void Stock_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            var Data = Stock.Items[Stock.SelectedIndex];
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
