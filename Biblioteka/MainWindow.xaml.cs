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

namespace Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LibruaryEntities entities = new LibruaryEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isCheck())
                {
                    Users users = entities.Users.FirstOrDefault(p => p.Login == LogBox.Text && p.Password == PassBox.Password);
                    switch (users.Role)
                    {
                        case ("Читатель"):
                            MessageBox.Show("Вы вошли как Читатель");
                            break;
                        case ("Администратор"):
                            MessageBox.Show("Вы вошли как Администратор");
                            break;
                    }
                    BooksWindow booksWindow = new BooksWindow();
                    booksWindow.Show();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Неверно");
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
        }

        private bool isCheck()
        {
                StringBuilder error = new StringBuilder();
                if (LogBox.Text == "") error.AppendLine("Введите логин");
                if (PassBox.Password == "") error.AppendLine("Введите пароль");
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return false;
                }
            return true;
        }
    }
}
