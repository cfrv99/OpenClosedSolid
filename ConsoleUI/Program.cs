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
            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new PersonModel { Firstname = "Tim", Lastname="Corey"},
                new ManagerModel{ Firstname="Sue", Lastname= "Storm" },
                new ExecutiveModel { Firstname="Nancy", Lastname="Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Firstname} {emp.Lastname} {emp.EmailAddress} {emp.IsManager} {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
