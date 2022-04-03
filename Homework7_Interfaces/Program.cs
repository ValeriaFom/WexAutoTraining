using System;
using System.Collections.Generic;

namespace Homework7_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 7.
            //Разработать классы для программы управления ИТ офисом.
            //1.Класс Office содержит список Employee, сотрудники бывают QAEmployee, DevEmployee, BAEmployee, PMEmployee, QAAutomationEmployee, QAAutomationTeamLead, DevTEamLead, QATeamLead. 
            //2.Ассайнить таски могут тимлиды и PMEmployee, делать ревью кода тимлиды QAAutomation и Dev.
            //3.Писать код могут Dev, QAAuto и их тимлиды. 
            //4.Заполнить список Employee специалистами разного профиля, и вывести подробную информацию о специлистах, которые могут
            //4.1 писать код
            //4.2 ассайнить таски
            //4.3 делать ревью кода

            Office issoft = new Office();

            issoft.Employees.Add(new DevTeamLead { firstName = "Elon", lastName = "Musk", jobTitle = "Developer/Team Lead", taxID = 1});
            issoft.Employees.Add(new DevEmployee { firstName = "Guy", lastName = "Ritchie", jobTitle = "Developer", taxID = 2});
            issoft.Employees.Add(new DevEmployee { firstName = "Bob", lastName = "Marley", jobTitle = "Developer", taxID = 3});
            issoft.Employees.Add(new QATeamLead { firstName = "Natalia", lastName = "Soyko", jobTitle = "QA Engineer/Team Lead", taxID = 4});
            issoft.Employees.Add(new QAEmployee { firstName = "Valeria", lastName = "Klimentieva", jobTitle = "QA Engineer", taxID = 5});
            issoft.Employees.Add(new QAEmployee { firstName = "Olga", lastName = "Kraskova", jobTitle = "QA Engineer", taxID = 6});
            issoft.Employees.Add(new QAAutomationTeamLead { firstName = "Alexander", lastName = "Savenok", jobTitle = "QA Auto Engineer/Team Lead", taxID = 7});
            issoft.Employees.Add(new QAAutomationEmployee { firstName = "Julia", lastName = "Dantsevich", jobTitle = "QA Auto Engineer", taxID = 8});
            issoft.Employees.Add(new BAEmployee { firstName = "Nastya", lastName = "Toporova", jobTitle = "Business Analysist", taxID = 9});
            issoft.Employees.Add(new PMEmployee { firstName = "Olga", lastName = "Rutskaya", jobTitle = "Project Manager", taxID = 10});

            Console.WriteLine($"\nWho can write a code:");
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ICodeWriter)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            Console.WriteLine($"\nWho can assign a task:");
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ITaskAssigner)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            Console.WriteLine($"\nWho can review a code:");
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ICodeReviewer)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
    }
}
