using System;
using System.Collections.Generic;

namespace Homework5_ClassBook
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

            var _allAuthors = new List<Author>
            {
                new Author ("Antoine", "de Saint-Exupéry", new DateTime (1900, 06, 29)),
                new Author ("Ray", "Bradbury", new DateTime(1920, 08, 22)),
                new Author ("James", "Barrie", new DateTime(1860, 5, 9)),
                //new Author { FirstName = "Mikhail", LastName = "Bulgakov", DateofBirth = new DateTime(1891, 5, 15) },
                //new Author { FirstName = "Nikolai", LastName = "Gogol", DateofBirth = new DateTime(1809, 4, 1) },
            };

            //foreach (var item in _allAuthors)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}, {item.DateofBirth}");
            //}

            new Book("qw", new Author("sds", "sds", new DateTime(2000, 6, 28)), new DateTime(2001, 12, 4), 78, 5);
            //new Book("qw", new Author("sds", "sds", new DateTime(2000, 6, 28)), 78, 5);
        }
    }
}
