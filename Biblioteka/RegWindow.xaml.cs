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

namespace Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {

        LibruaryEntities entities = new LibruaryEntities();
        Users users = new Users();
        public RegWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            users.Login = LogBox.Text;
            users.Password = PassBox.Password;
            users.Role = "Читатель";
            entities.Users.Add(users);
            entities.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!");
            Close();
        }

        private bool isCheck()
        {
            if (isCheck())
            {
                StringBuilder error = new StringBuilder();
                if (LogBox.Text == "") error.AppendLine("Введите логин");
                if (PassBox.Password == "") error.AppendLine("Введите пароль");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return false;
                }
            }
                return true;
        }
    }
}
