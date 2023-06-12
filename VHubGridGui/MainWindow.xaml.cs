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

using RouterApiWrapper;

namespace VHubGridGui {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            RouterApiWrapperClass routerApiWrapper = new RouterApiWrapperClass();
            int result = 0;
            result = routerApiWrapper.AddRouter("127.0.0.1");

            textBox.Text = result.ToString();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
        }
    }
}
