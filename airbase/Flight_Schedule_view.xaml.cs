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
using System.Configuration;
namespace airbase
{
    /// <summary>
    /// Interaction logic for Flight_Schedule_view.xaml
    /// </summary>
    public partial class Flight_Schedule_view : Window
    {
        public Flight_Schedule_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=shivam;Database=chawlaairbase");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from flight_schedule", conn);
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
    }
}
