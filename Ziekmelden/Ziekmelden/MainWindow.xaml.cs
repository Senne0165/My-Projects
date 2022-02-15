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

namespace Ziekmelden
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
            dgZieken.ItemsSource = db.Zieks.ToList();
        }

        private void btnVerstuur_Click(object sender, RoutedEventArgs e)
        {
            Persoon per = new Persoon();
            per.Voornaam = txtVoornaam.Text;
            per.Achternaam = txtAchternaam.Text;
            per.Afdeling = txtAfdeling.Text;

            Ziek dat = new Ziek();
            dat.DatumZ = dateZiek.DisplayDate;
            dat.DatumB = dateBeter.DisplayDate;
            dat.Persoon= per;

            
            db.Zieks.InsertOnSubmit(dat);
            db.SubmitChanges();
        }

        private void dgZieken_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

