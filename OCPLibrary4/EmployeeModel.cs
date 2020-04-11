using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary4
{
    public class EmployeeModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}
