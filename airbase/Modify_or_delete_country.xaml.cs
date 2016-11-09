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
    /// Interaction logic for Modify_or_delete_country.xaml
    /// </summary>
    public partial class Modify_or_delete_country : Window
    {
        public Modify_or_delete_country()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=dharmendra;Database=chawlaairbase");
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                conn.Open();
                int ctid = Convert.ToInt32(comboBox.SelectedItem);
                MySqlCommand cmd = new MySqlCommand("Select * from countries where CtID=" + ctid + ";", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBox1.Text = dr["CountryName"].ToString();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from countries", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var valen = dr["CtID"];
                    if (!comboBox.Items.Contains(valen))
                    {
                        comboBox.Items.Add(valen);
                    }
                }
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
            if(radioButton1.IsChecked==true)
            {
                try
                {
                    conn.Open();
                    int ctid = Convert.ToInt32(comboBox.SelectedItem);
                    string cntnm = textBox1.Text;
                    MySqlCommand cmd = new MySqlCommand("update countries set CountryName= '"+cntnm+"' where CtID="+ctid+";", conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var valen = dr["CtID"];
                        if (!comboBox.Items.Contains(valen))
                        {
                            comboBox.Items.Add(valen);
                        }
                    }
                    MessageBox.Show("Successfully updated");
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
            else
            {
                MessageBox.Show("Select Modify first");
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           if(radioButton.IsChecked==true)
            {
                try
                {
                    conn.Open();
                    int ctid = Convert.ToInt32(comboBox.SelectedItem);
                    string cntnm = textBox1.Text;
                    MySqlCommand cmd = new MySqlCommand("delete from countries where CtID="+ctid+";", conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var valen = dr["CtID"];
                        if (!comboBox.Items.Contains(valen))
                        {
                            comboBox.Items.Add(valen);
                        }
                    }
                    MessageBox.Show("Successfully updated");
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
            else
            {
                MessageBox.Show("Select Delete Button First");
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
