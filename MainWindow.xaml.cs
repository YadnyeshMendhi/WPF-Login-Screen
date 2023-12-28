using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
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


            if(txtUsername.Text == "Yadynesh" && txtPassword.Password == "Yadynesh@2001")
            {
                Window1 window1 = new Window1();
                window1.Show();
                Close();
                //MessageBox.Show("Login Successful !");
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials");
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }
    }
}
