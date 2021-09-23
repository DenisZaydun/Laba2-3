using System;

namespace Лб2__3
{
    class Book
    {
        public class Title
        {
            private string _title;
            public string title
            {
                get
                {
                    return _title;
                }
                set
                {
                    _title = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Назва книги: " + title);
                Console.ResetColor();
            }
        }
        public class Author
        {
            private string _autor;
            public string autor
            {
                get
                {
                    return _autor;
                }
                set
                {
                    _autor = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Автор книги: " + autor);
                Console.ResetColor();
            }
        }
        public class Content
        {
            private string _content;
            public string content
            {
                get
                {
                    return _content;
                }
                set
                {
                    _content = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Зміст книги: " + content);
                Console.ResetColor();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            Book.Title nazva = new Book.Title();
            Book.Author avtor = new Book.Author();
            Book.Content soderzh = new Book.Content();

            Console.Write("Введіть назву книги: ");
            nazva.title = Console.ReadLine();

            Console.Write("Введіть автора книги: ");
            avtor.autor = Console.ReadLine();

            Console.Write("Введіть зміст книги: ");
            soderzh.content = Console.ReadLine();

            nazva.Show();
            avtor.Show();
            soderzh.Show();

            Console.ReadKey();
        }
    }
}
