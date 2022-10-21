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

namespace RetânguloApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Retangulo r = new Retangulo();
            r.SetBase(double.Parse(txt_base.Text));
            r.SetAltura(double.Parse(txt_altura.Text));
            txt_area.Text = r.CalcArea().ToString("0.00");
            txt_diagonal.Text = r.CalcDiagon().ToString("0.00");


        }
    }
}
