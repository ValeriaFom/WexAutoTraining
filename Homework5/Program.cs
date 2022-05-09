using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5_ClassBook_Homework9_BookCatalog
{
    class Program
    {
        
        static void Main(string[] args)
        {
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

            //Homework 10
            //1.Сделать в классе Каталог поле с коллекцией книг приватным, реализовать метод, добавляющий книгу в коллекцию. Если такая книга уже есть в коллекции - бросать Exception.
            //2.На все методы написать unit tests.

            var catalog = new Catalog();

            try
            {
                catalog.AddBook("Peter Pan",
                    new List<Author>()
                    {
                    new Author("James", "Barrie", new DateTime(1860, 5, 9)),
                    new Author("52", "2782", new DateTime(1861, 4, 9))
                    },
                    new DateTime(1900, 12, 4), 54, 1);

                catalog.AddBook("Fahrenheit 451",
                    new List<Author>()
                    {
                    new Author("Ray", "Bradbury", new DateTime(1920, 08, 22)),
                    new Author("52", "2782", new DateTime(1861, 4, 9))
                    },
                    new DateTime(1980, 05, 15), 101, 2);

                catalog.AddBook("Le Petit Prince",
                    new List<Author>()
                    {
                    new Author("Antoine", "de Saint-Exupéry", new DateTime(1900, 06, 29))
                    },
                    new DateTime(1942, 03, 24), 73, 3);

                catalog.AddBook("Dandelion Wine",
                    new List<Author>()
                    {
                    new Author("Ray", "Bradbury", new DateTime(1920, 08, 22))
                    },
                    new DateTime(1964, 01, 31), 164, 4);

                catalog.AddBook("The Master and Margarita",
                    new List<Author>()
                    {
                    new Author("Mikhail", "Bulgakov", new DateTime(1891, 5, 15))
                    },
                    new DateTime(2001, 10, 29), 268, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var book in catalog)
            {
                Console.WriteLine(book.ToString());
            }

            ////1 point
            //var booksSortedByName = catalog.GetBooksSortedByName();
            //Console.WriteLine("\n");
            //foreach (var book in booksSortedByName)
            //{
            //    Console.WriteLine(book.ToString());
            //}

            ////2 point            
            //var authorsFromCatalog = catalog.GetAuthorsFromCatalog();
            //Console.WriteLine("\n");
            //foreach (var author in authorsFromCatalog)
            //{
            //    Console.WriteLine(author.ToString());
            //}

            ////3 point
            //var result = catalog.GetBooksByAuthor("52", "2782");

            //var booksOfAuthorPublichedAfterData = catalog.GetBooksOfAuthorPublichedAfterData("Bradbury", "Ray", new DateTime(1970, 1, 1));
            //Console.WriteLine("\n");
            //foreach (var book in booksOfAuthorPublichedAfterData)
            //{
            //    Console.WriteLine(book.ToString());
            //}

            ////4 point
            //var authorsSortedByDateOfBirth = catalog.GetAuthorsSortedByDateOfBirth();
            //Console.WriteLine("\n");
            //foreach (var author in authorsSortedByDateOfBirth)
            //{
            //    Console.WriteLine(author.ToString());
            //}
        }
    }
}
