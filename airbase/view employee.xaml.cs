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
using System.Data;
using MySql.Data.MySqlClient;
namespace airbase
{
    /// <summary>
    /// Interaction logic for view_employee.xaml
    /// </summary>
    public partial class view_employee : Window
    {
        public view_employee()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=dharmendra;Database=chawlaairbase");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from employee", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                dataGrid.DataContext = ds;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
