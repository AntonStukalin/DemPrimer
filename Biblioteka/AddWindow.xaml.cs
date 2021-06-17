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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        LibruaryEntities entities = new LibruaryEntities();
        Books books = new Books();
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            books.Auther = AuthorBox.Text;
            books.Name = NameBox.Text;
            books.Text = TextBox.Text;
            entities.Books.Add(books);
            entities.SaveChanges();
            MessageBox.Show("Книга добавлена");
            Close();
        }

        private bool isCheck()
        {
                StringBuilder error = new StringBuilder();
                if (AuthorBox.Text == "") error.AppendLine("Введите автора");
                if (NameBox.Text == "") error.AppendLine("Введите название");
            if (TextBox.Text == "") error.AppendLine("Введите описание");
            if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return false;
                }
            return true;
        }
    }
}
