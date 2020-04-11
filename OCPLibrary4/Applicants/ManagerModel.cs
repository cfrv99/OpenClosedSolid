using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary4
{
    public class ManagerModel : IApplicantModel
    {
        public string Firstname { get; set; }        
        public string Lastname { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
