using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceWalkthrough
{
    public class Movie : Product, IHtmlObject
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

        #region IHtmlObject Members

        public override void Render(IHtmlStream inStream)
        {
            base.Render(inStream);
            inStream.Write("- " + Code + "<br />");
        }

        #endregion
    }
}
