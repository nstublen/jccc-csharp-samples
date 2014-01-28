using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceWalkthrough
{
    public class Movie : Product
    {
        public TimeSpan Runtime { get; set; }

        public Movie()
        {
        }

        public override bool ValidateCode(string inCode)
        {
            if (!inCode.StartsWith("MV"))
            {
                return false;
            }
            return true;
        }
    }
}
