using OCPLibrary4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>()
            {
                new PersonModel {Firstname = "Tim",Lastname="Corey"},
                new PersonModel{Firstname="Sue",Lastname= "Storm",TypeOfEmployee=EmployeeType.Manager},
                new PersonModel{Firstname="Nancy",Lastname="Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Firstname} {emp.Lastname} {emp.EmailAddress} {emp.IsManager}");
            }

            Console.ReadLine();
        }
    }
}
