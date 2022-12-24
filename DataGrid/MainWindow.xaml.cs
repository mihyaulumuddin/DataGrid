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

namespace DataGrid
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
            int i = 1;
            string nama = tbName.Text;
            string birthday = tbAge.Text;
            string add = tbAddress.Text;
            string contact = tbContact.Text;

            List<User> users = new List<User>();
            users.Add(new User()
            {
                Id = i,
                Name = nama,
                Age = birthday,
                Address = add,
                Contact = contact
            });

            dgUsers.ItemsSource = users;
            tbName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbContact.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbContact.Text = "";
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
