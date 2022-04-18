using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Homework 5
            //Cоздать класс Книга (в нем название (строка), количество страниц (int), уникальный идентификатор (строка).
            //Создайте массив книг (5 штук) проинициализируйте его различными объектами типа "Книга", и выведите информацию о всех книгах в массиве на экран

            //Book book1 = new Book { Name = "Peter Pan", NumberOfPages = 54, ID = 1 };
            //Book book2 = new Book { Name = "Fahrenheit 451", NumberOfPages = 101, ID = 2 };
            //Book book3 = new Book { Name = "Le Petit Prince", NumberOfPages = 73, ID = 3 };
            //Book book4 = new Book { Name = "Dandelion Wine", NumberOfPages = 164, ID = 4 };
            //Book book5 = new Book { Name = "The Master and Margarita", NumberOfPages = 268, ID = 5 };

            //Book[] shelf1 = { book1, book2, book3, book4, book5 };

            //foreach (Book item in shelf1)
            //{
            //    Console.WriteLine($"Book name: {item.Name}, Number of pages: {item.NumberOfPages}, ID: {item.ID}");
            //}

            //Homework 9
            //Для программы по обслуживания функционирования библиотеки создать следующие классы:
            //Автор(имя, фамилия, дата рождения), 
            //Книга(включающая название, дату публикации, уникальный ID, список авторов),
            //Каталог(включающий коллекцию книг).
            //Для класса Каталог создать методы, позволяющие: 
            //1.Получить список всех книг, отсортированных по названию
            //2.Получить список всех авторов, книги которых есть в каталоге
            //3.Получить список всех книг конкретного автора, напечатанные после заданного года
            //4.Получить список всех авторов, отсортированных по году рождения

            var catalog = new Catalog();

            //catalog.Books.AddRange(   // ????????? чтобы не писать catalog.Books.Add каждый раз

            catalog.Books.Add(
                new Book("Peter Pan",
                new List<Author>()
                {
                    new Author("James", "Barrie", new DateTime(1860, 5, 9)),
                    new Author("52", "2782", new DateTime(1860, 5, 9))
                },
                new DateTime(1900, 12, 4), 54, 1));
            catalog.Books.Add(
                new Book("Fahrenheit 451",
                new List<Author>()
                {
                    new Author("Ray", "Bradbury", new DateTime(1920, 08, 22)),
                    new Author("52", "2782", new DateTime(1860, 5, 9))
                },
                new DateTime(1980, 05, 15), 101, 1));
            //catalog.Books.Add(
            //    new Book("Le Petit Prince",
            //    new Author("Antoine", "de Saint-Exupéry", new DateTime(1900, 06, 29)),
            //    new DateTime(1942, 03, 24), 73, 2));
            //catalog.Books.Add(
            //    new Book("Dandelion Wine",
            //    new Author("Ray", "Bradbury", new DateTime(1920, 08, 22)),
            //    new DateTime(1964, 01, 31), 164, 3));
            //catalog.Books.Add(
            //    new Book("The Master and Margarita",
            //    new Author("Mikhail", "Bulgakov", new DateTime(1891, 5, 15)),
            //    new DateTime(2001, 10, 29), 268, 4));

            var allAuthors = catalog.Books.SelectMany(x => x.Authors).ToList();


            foreach (var book in catalog)
            {
                Console.WriteLine(book.ToString());
            }

            //var list = new List<Book>
            //{
            //    new Book("Peter Pan",
            //        new Author("James", "Barrie", new DateTime(1860, 5, 9)),
            //        new DateTime(1900, 12, 4), 54, 1)
            //};

            //1 point
            var booksSortedByName = catalog.GetBooksSortedByName();
            Console.WriteLine("\n");
            foreach (var book in booksSortedByName)
            {
                Console.WriteLine(book.ToString());
            }

            //2 point            
            var authorsFromCatalog = catalog.GetAuthorsFromCatalog();
            Console.WriteLine("\n");
            foreach (var author in authorsFromCatalog)
            {
                Console.WriteLine(author.ToString());
            }

            var result = catalog.GetBooksByAuthor2("52", "2782");

            //3 point
            //можно ли объединить 2 метода в 1 коллекцию?
            //var booksOfAuthorPublichedAfterData4 = catalog.GetBooksByAuthor("Bradbury", "Ray") && catalog.GetBooksPublishedAfterData(1970, 1, 1);

            //var booksOfAuthorPublichedAfterData = catalog.GetBooksPublishedAfterData(1970, 1, 1);  

            //var booksOfAuthorPublichedAfterData2 = catalog.GetBooksByAuthor("Bradbury", "Ray");

            //var booksOfAuthorPublichedAfterData3 = catalog.Books.Where(IsBookPublishedAfterData && IsBookWrittenByAuthor); // ??????

            var booksOfAuthorPublichedAfterData3 = catalog.GetBooksOfAuthorPublichedAfterData("Bradbury", "Ray", new DateTime(1970, 1, 1));  //???? каких аргументов не хватает?
            Console.WriteLine("\n");
            foreach (var book in booksOfAuthorPublichedAfterData3)
            {
                Console.WriteLine(book.ToString());
            }

            //4 point
            var authorsSortedByDateOfBirth = catalog.GetAuthorsSortedByDateOfBirth();
            Console.WriteLine("\n");
            foreach (var author in authorsSortedByDateOfBirth)
            {
                Console.WriteLine(author.ToString());
            }
            var res = catalog.Books;

        }
    }
}
