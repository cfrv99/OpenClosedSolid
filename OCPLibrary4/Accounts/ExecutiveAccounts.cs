using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary4
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.Firstname = person.Firstname;
            output.Lastname = person.Lastname;
            output.EmailAddress = $"{person.Firstname.Substring(0, 1)}{person.Lastname}@acme.com";
            output.IsManager = true;
            output.IsExecutive = true;
            
            return output;

        }
    }
}
