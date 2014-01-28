using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceWalkthrough
{
    public abstract class Product
    {
        private string mCode;

        public Product()
        {
        }

        public string Code
        {
            get { return mCode; }
            set
            {
                if (ValidateCode(value))
                {
                    mCode = value;
                }
                else
                {
                    throw new Exception("Invalid product code");
                }
            }
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract bool ValidateCode(string inCode);
    }
}
