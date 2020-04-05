using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary4
{
    public class PersonModel : IApplicantModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
    }
}
