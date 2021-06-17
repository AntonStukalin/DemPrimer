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
    /// Логика взаимодействия для BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        LibruaryEntities entities = new LibruaryEntities();
        public BooksWindow()
        {
            InitializeComponent();
            BooksGrid.AutoGenerateColumns = false;
            BooksGrid.ItemsSource = entities.Books.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            BooksGrid.ItemsSource = entities.Books.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (BooksGrid.SelectedItems.Count > 0)
            {
                Books books = (Books)BooksGrid.SelectedItems[0];
                if(MessageBox.Show("Удалить?","Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    entities.Books.Remove(books);
                    entities.SaveChanges();
                }
            }
        }
    }
}
