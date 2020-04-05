using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary4
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.EmailAddress = $"{person.Firstname.Substring(0, 1)}{person.Lastname}@acme.com";

            //if (person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    output.IsManager = true;
            //}
            //switch (person.TypeOfEmployee)
            //{
            //    case EmployeeType.Staff:
            //        break;
            //    case EmployeeType.Manager:
            //        output.IsManager = true;
            //        break;
            //    case EmployeeType.Executive:
            //        output.IsManager = true;
            //        output.IsExecutive = true;
            //        break;
            //    default:
            //        break;
            //}
            return output;
        }
    }
}
