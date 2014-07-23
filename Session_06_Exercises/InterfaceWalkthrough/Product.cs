using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceWalkthrough
{
    public abstract class Product : IHtmlObject
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

        #region IHtmlObject Members

        public virtual void Render(IHtmlStream inStream)
        {
            inStream.Write("<b>");
            inStream.Write(Name);
            inStream.Write("</b> ");
            inStream.Write(Price.ToString("c"));
            inStream.Write("<br /> ");
        }

        #endregion
    }
}
