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
using System.Data.Entity;
using System.Windows.Shapes;
using LibrarySolution;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books;
        List<Author> authors;
        BookAuthor bookWithAuthor;
        public MainWindow()
        {
            Data data = new Data();

            InitializeComponent();
            Database.SetInitializer(new CustomInitializer<LibraryDb>());
            MaintainDb db = new MaintainDb();
            Author jkrow = new Author("Joanne", "Rowling", "Harry Potter's mother");
            Book hp1 = new Book("Harry Potter and the Philosopher's Stone", 1, 1997, "English", 223);
            data.addAuthor(jkrow);
            data.addBook(hp1);
            books = data.getBooks();
            authors = data.getAuthors();

            foreach (Book b in books)
            {
                foreach (Author a in authors)
                {
                    if (b.authorId == a.id)
                    {
                        bookWithAuthor = new BookAuthor(b, a);
                        System.Console.WriteLine(bookWithAuthor.Id + " " + bookWithAuthor.Title);
                        DataContext = bookWithAuthor;
                    }

                }
            }


        }

        private void button_click(object sender, RoutedEventArgs e)
        {

            bookWithAuthor.Title = "Harry Potter and the Chamber of Secrets";

        }


        public class BookAuthor : INotifyPropertyChanged
        {
            private int id;
            public int Id
            {
                get { return id; }
                set
                {
                    id = value;
                    onPropertyChanged();
                }
            }
            private string title;
            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    onPropertyChanged();
                }
            }
            public string author { get; set; }

            public BookAuthor(Book book, Author author)
            {
                id = book.id;
                title = book.Title;
                this.author = author.firstName + " " + author.lastName;
            }

            public event PropertyChangedEventHandler PropertyChanged;
            private void onPropertyChanged(
                [CallerMemberName] string caller = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(caller));
                }
            }

        }
    }
}
