using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceWalkthrough
{
    public class Book : Product
    {
        public string ISBN { get; set; }

        public Book()
        {
        }

        public override bool ValidateCode(string inCode)
        {
            if (!inCode.StartsWith("BK"))
            {
                return false;
            }
            return true;
        }
    }
}
