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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Window1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Customer cust = new Customer();
            cust.Firstname = txtFName.Text;
            cust.Lastname = txtLName.Text;
            cust.City = txtCity.Text;
            cust.PhoneNumber = txtPhone.Text;
            cust.EMail = txtMail.Text;

            db.Customers.InsertOnSubmit(cust);
            db.SubmitChanges();


        }
    }
}
