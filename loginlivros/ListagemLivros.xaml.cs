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

namespace loginlivros
{
    /// <summary>
    /// Interaction logic for ListagemLivros.xaml
    /// </summary>
    public partial class ListagemLivros : Window
    {
        public ListagemLivros()
        {
            InitializeComponent();

            displayBooks();
        }

        private void displayBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Histórias Extraordinárias", "Allan Poe", 1924));
            books.Add(new Book("Eu, Robô", "Isaac Asimov", 1950));
            books.Add(new Book("Um Estudo em Vermelho", "Arthur Conan Doyle", 1887));

            this.dtgFilmes.ItemsSource = books;
        }
    }
}
