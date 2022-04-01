using System;

namespace Homework5_ClassBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 5
            //Cоздать класс Книга (в нем название (строка), количество страниц (int), уникальный идентификатор (строка).
            //Создайте массив книг (5 штук) проинициализируйте его различными объектами типа "Книга", и выведите информацию о всех книгах в массиве на экран


            Book book1 = new Book { Name = "Peter Pan", NumberOfPages = 54, ID = "1" };
            Book book2 = new Book { Name = "Fahrenheit 451", NumberOfPages = 101, ID = "2" };
            Book book3 = new Book { Name = "Le Petit Prince", NumberOfPages = 73, ID = "3" };
            Book book4 = new Book { Name = "Dandelion Wine", NumberOfPages = 164, ID = "4" };
            Book book5 = new Book { Name = "The Master and Margarita", NumberOfPages = 268, ID = "5" };

            Book[] shelf1 = { book1, book2, book3, book4, book5 };

            foreach (Book item in shelf1)
            {
                Console.WriteLine($"Book name: {item.Name}, Number of pages: {item.NumberOfPages}, ID: {item.ID}");
            }

        }
    }
}
