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
using Logic.Model;
using Authorization.Admin;
using Authorization.Director;
using Authorization.Manager;
using Logic;
namespace Authorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Login = login.Text;
                string Password = password.Text;
                int roll = AuthorizationProcess.GetRollUser(Login, Password);
                StaticValue.RollUser = roll;
                switch (roll)
                {
                    case 1:
                        
                        MainAdmin admin = new MainAdmin();
                        admin.Show();
                        this.Close();
                        break;
                    case 2:
                        MainDirector director = new MainDirector();
                        director.Show();
                        this.Close();
                        break;
                    case 3:
                        MainManager manager = new MainManager();
                        manager.Show();
                        this.Close();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void GoRegistration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
