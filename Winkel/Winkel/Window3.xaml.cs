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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Window3()
        {
            InitializeComponent();
            cbLname.ItemsSource = (from Customer in db.Customers select (Customer.Lastname));

            cbProduct.ItemsSource = (from Product in db.Products select (Product.Productname));

            cbOrder.ItemsSource = (from Order in db.Orders select (Order.OrderID));


        }

        public void LaadCb()
        {
            cbLname.ItemsSource = (from Customer in db.Customers select (Customer.Lastname));
            cbProduct.ItemsSource = (from Product in db.Products select (Product.Productname));
            cbOrder.ItemsSource = (from Order in db.Orders select (Order.OrderID));
        }

        private void btnNieuw_Click(object sender, RoutedEventArgs e)
        {
            var keuze = cbLname.SelectedItem.ToString();


            Order ord = new Order();
            int CustomerID = ((from Customer in db.Customers where Customer.Lastname == (cbLname.SelectedItem.ToString()) select (Customer.CustomerID)).Single());
            ord.CustomerID = CustomerID;
            ord.OrderDate = DateTime.Now.Date;
            db.Orders.InsertOnSubmit(ord);
            db.SubmitChanges();
            LaadCb();

        }

        private void btnVerzend_Click(object sender, RoutedEventArgs e)
        {
            int orderID = 0;
            if (Int32.TryParse(cbOrder.SelectedItem.ToString(), out orderID))
            {
                Item it = new Item();
                it.ProductID = (from Product in db.Products where Product.Productname == (cbProduct.SelectedItem.ToString()) select (Product.ProductID)).Single();

                it.OrderID = orderID;
                it.Amount = txtAantal.Text;

                db.Items.InsertOnSubmit(it);
                db.SubmitChanges();
                LaadCb();
            }
        }
    }
}

