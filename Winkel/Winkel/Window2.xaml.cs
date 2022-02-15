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
using System.Windows.Shapes;

namespace Winkel
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Window2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Product prod = new Product();
            prod.Productname = txtPName.Text;
            prod.ProductPrice = txtPPrice.Text;

            db.Products.InsertOnSubmit(prod);
            db.SubmitChanges();
        }
    }
}
