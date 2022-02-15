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

namespace Winkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();
            secondWindow.Show();
        }

        private void btnItems_Click(object sender, RoutedEventArgs e)
        {
            Window2 thirdWindow = new Window2();
            thirdWindow.Show();
        }

        private void btnWinkel_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window3 fourthWindow = new Window3();
            fourthWindow.Show();
        }
    }
}
