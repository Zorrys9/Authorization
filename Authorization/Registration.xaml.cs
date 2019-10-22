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
using Logic.ViewModel;
using Logic.Model;
namespace Authorization
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Dictionary<int, string> rolles = new Dictionary<int, string>();
        public Registration()
        {
            try
            {
                InitializeComponent();
                rolles = RollesView.GetRoll();
                RollName.ItemsSource = rolles.Values;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
 
        }
        private void RegistrationGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string lastName = LastName.Text;
                string firstName = FirstName.Text;
                string patronymic = Patronymic.Text;
                string login = Login.Text;
                string password = Password.Text;
                string retryPassword = RetryPassword.Text;
                string rollName = RollName.Text;
                int roll=0;
                if (password == retryPassword)
                {
                    foreach (var item in rolles)
                    {
                        if (item.Value == rollName)
                            roll = item.Key;
                    }
                    if (RegistrationProcess.SaveUser(lastName, firstName, patronymic, login, password, roll))
                        MessageBox.Show("Регистрация прошла успешно!");
                    MainWindow Authorization = new MainWindow();
                    Authorization.Show();
                    this.Close();
                }
                else throw new Exception("Пароли не совпадают");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
