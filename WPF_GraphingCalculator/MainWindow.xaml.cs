using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_GraphingCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Graphics _graphic;
        Timer _timer;
        System.Drawing.Pen _pen = new System.Drawing.Pen(System.Drawing.Color.Blue, 1f);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // load axes
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += new ElapsedEventHandler(RedrawPage);
            _timer.Enabled = true;
        }

        private void RedrawPage(object sender, ElapsedEventArgs e)
        {
            DrawPage();

            _timer.Enabled = false;
        }

        private void DrawPage()
        {

        }
    }
}
