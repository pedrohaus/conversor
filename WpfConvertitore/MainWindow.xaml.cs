using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfConvertitore.ViewModels;

namespace WpfConvertitore
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConvertitoreViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new ConvertitoreViewModel();
            DataContext = vm;

            vm.Monete = new ObservableCollection<string> { "DEM", "ITL", "FRF" };
        }

        private void Convertire_Click(object sender, RoutedEventArgs e)
        {
            vm.ConvertireMoneta();
        }

        private void Scambio_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
