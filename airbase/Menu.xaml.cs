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
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
namespace airbase
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=dharmendra;Database=chawlaairbase");
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Add_aircraft men = new Add_aircraft();
            men.Show();
            this.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            add_countries men = new add_countries();
            men.Show();
            this.Close();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            Modify_or_delete_country men = new Modify_or_delete_country();
            men.Show();
            this.Close();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            ADD_State men = new ADD_State();
            men.Show();
            this.Close();

        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            Modify_or_delete_state men = new Modify_or_delete_state();
            men.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Flight_Schedule_view men = new Flight_Schedule_view();
            men.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           Aircraft_view men = new Aircraft_view();
            men.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            passenger_signup men = new passenger_signup();
            men.Show();
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Cancel_ticket1 men = new Cancel_ticket1();
            men.Show();
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            State_view men = new State_view();
            men.Show();
            this.Close();
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            country_view men = new country_view();
            men.Show();
            this.Close();
        }
    }
}
