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

namespace EventDepartmentManager
{
    /// <summary>
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
            PasswordBox.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "1234")
            {
                MainWindow wnd = new MainWindow();
                wnd.Show();
                this.Close();
            }

        }

 
    }
}
