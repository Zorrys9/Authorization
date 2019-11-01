using Logic.Model;
using Logic.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;
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
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
        private void RegistrationGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserRegistrationModel newUser = new UserRegistrationModel();

                newUser.FirstName = FirstName.Text;
                newUser.LastName = LastName.Text;
                newUser.Patronymic = Patronymic.Text;
                newUser.Login = Login.Text;

                foreach (var item in rolles)
                {
                    if (item.Value == RollName.Text)
                        newUser.Rolle = item.Key;
                }

                if (Password.Text == RetryPassword.Text)
                    newUser.Password = Password.Text;
                else throw new Exception("Введенные пароли не совпадают");

                UserLogic.Registration(newUser);

                MessageBox.Show("Регистрация прошла успешно!");

                MainWindow Authorization = new MainWindow();
                Authorization.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
