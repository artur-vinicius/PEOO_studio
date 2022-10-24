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

namespace AbastecimentoApp
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
            Abastecimento a = new Abastecimento();
            a.SetKmRodados(double.Parse(txt_km.Text));
            a.SetValorLitro(double.Parse(txt_vl.Text));
            a.SetValorPago(double.Parse(txt_vp.Text));
            txt_kml.Text = a.MediaKmLitro().ToString("0.00");
            txt_RKm.Text = a.MediaReaisKm().ToString("0.00");
        }
    }
}
