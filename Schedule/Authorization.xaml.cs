using Schedule.Windows;
using System.Windows;

namespace Schedule
{
    public partial class Authorization : Window
    {
        ScheduleWindow scheduleWindow = new ScheduleWindow();
        PrepaidExpense expense = new PrepaidExpense();
        private string loginAdmin = string.Empty, loginEmployee = string.Empty;
        private string passwordAdmin = string.Empty, passwordEmployee = string.Empty;
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
