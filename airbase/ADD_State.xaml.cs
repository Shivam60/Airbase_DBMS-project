﻿using System;
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
    /// Interaction logic for ADD_State.xaml
    /// </summary>
    public partial class ADD_State : Window
    {
        public ADD_State()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;userid=root;password=shivam;Database=chawlaairbase");
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
