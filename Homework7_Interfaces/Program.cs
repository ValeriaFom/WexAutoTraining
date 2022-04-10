using System;
using Homework7and8_Interfaces_IComparer.Comparers;
using System.Linq;

namespace Homework7and8_Interfaces_IComparer
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

            issoft.Employees.Add(new DevTeamLead { FirstName = "Elon", LastName = "Musk", jobTitle = "Developer/Team Lead", TaxID = 1});
            issoft.Employees.Add(new DevEmployee { FirstName = "Guy", LastName = "Ritchie", jobTitle = "Developer", TaxID = 2});
            issoft.Employees.Add(new DevEmployee { FirstName = "Bob", LastName = "Marley", jobTitle = "Developer", TaxID = 3});
            issoft.Employees.Add(new QATeamLead { FirstName = "Natalia", LastName = "Soyko", jobTitle = "QA Engineer/Team Lead", TaxID = 4});
            issoft.Employees.Add(new QAEmployee { FirstName = "Valeria", LastName = "Klimentieva", jobTitle = "QA Engineer", TaxID = 5});
            issoft.Employees.Add(new QAEmployee { FirstName = "Olga", LastName = "Kraskova", jobTitle = "QA Engineer", TaxID = 6});
            issoft.Employees.Add(new QAAutomationTeamLead { FirstName = "Alexander", LastName = "Savenok", jobTitle = "QA Auto Engineer/Team Lead", TaxID = 7});
            issoft.Employees.Add(new QAAutomationEmployee { FirstName = "Julia", LastName = "Dantsevich", jobTitle = "QA Auto Engineer", TaxID = 8});
            issoft.Employees.Add(new BAEmployee { FirstName = "Nastya", LastName = "Toporova", jobTitle = "Business Analysist", TaxID = 9});
            issoft.Employees.Add(new PMEmployee { FirstName = "Olga", LastName = "Rutskaya", jobTitle = "Project Manager", TaxID = 10});

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

            //Homework 8.
            //Задача для всех - отсортируйте и выведите в консоль сотрудников по: 
            //1.Имени
            //2.TaxID
            //3.Общей длине имени и фамилии
            //4 * Умению ассанить таски-ITaskAssigner сначала(их дополнительно отсортировать по фамилии), потом все остальные

            issoft.Employees.Sort(new FirstNameComparer());
            Console.WriteLine($"\nEmployees sorted by First Name:");   //почему показывается employee.ToString() в консоли?
            foreach (Employee employee in issoft.Employees)
            {
                Console.WriteLine(employee);
            }            

            var employeesOrderedByTaxID = issoft.Employees.OrderBy(x => x.TaxID);
            Console.WriteLine($"\nEmployees sorted by Tax ID:");
            foreach (Employee employee in employeesOrderedByTaxID)
            {
                Console.WriteLine(employee);
            }

            var employeesOrderedByFullNameLength = issoft.Employees.OrderBy(x => x.FirstName.Length + x.LastName.Length);
            Console.WriteLine($"\nEmployees sorted by Full Name Length:");
            foreach (Employee employee in employeesOrderedByFullNameLength)
            {
                Console.WriteLine(employee);
            }
            
            issoft.Employees.Sort();
            Console.WriteLine($"\nEmployees - task assigners, sorted by Last Name, and then the others:");
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is ITaskAssigner)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("----------");
            foreach (Employee employee in issoft.Employees)
            {
                if (employee is not ITaskAssigner)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
