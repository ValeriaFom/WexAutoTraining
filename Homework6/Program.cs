using System;

namespace Homework6_AbstractClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать абстрактный класс Покупатель, у которого есть абстрактный метод Оплатить. 
            //2.Создать наследников от этого класса-Покупатель за наличные, покупатель с дебетовой картой, и покупатель с кредитной картой.
            //3.Реализовать в них метод Оплатить(пусть просто выводит на экран способ оплаты)
            //4.Создать массив из 5 покупателей разного типа, и в цикле вызвать метод Оплатить. Проверить что каждый оплатил своим способом(сообщения на экране)

            Customer customer1 = new CustomerWithCreditCard();
            Customer customer2 = new CustomerWithDebitCard();
            Customer customer3 = new CustomerWithCash();
            Customer customer4 = new CustomerWithCash();
            Customer customer5 = new CustomerWithDebitCard();

            Customer[] allCustomers = { customer1, customer2, customer3, customer4, customer5 };

            foreach (Customer item in allCustomers)
            {
                item.Pay();                
            }
        }
    }
}
