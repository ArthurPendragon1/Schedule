using Schedule.Windows;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Schedule
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        ScheduleWindow scheduleWindow = new ScheduleWindow();
        PrepaidExpense expense = new PrepaidExpense();
        private string loginAdmin, loginEmployee;
        private string passwordAdmin, passwordEmployee;
        public Authorization()
        {
            InitializeComponent();
        }
        private void JoinToProgram(object sender, RoutedEventArgs e)
        {
            loginAdmin = loginTextBox.Text; loginEmployee = loginTextBox.Text;
            passwordAdmin = passwordTextBox.Password; passwordEmployee = passwordTextBox.Password;

            if (loginTextBox.Text == "admin" && passwordTextBox.Password == "admin" || loginTextBox.Text == "employee" && passwordTextBox.Password == "employee")
            {
                if (loginTextBox.Text == "admin" && passwordTextBox.Password == "admin")
                {
                    Close();
                    scheduleWindow.Show();
                }
                if (loginTextBox.Text == "employee" && passwordTextBox.Password == "employee")
                {
                    Close();
                    expense.Show();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
    }
}
