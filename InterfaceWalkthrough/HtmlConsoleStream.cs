using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceWalkthrough
{
    class HtmlConsoleStream : IHtmlStream
    {
        #region IHtmlStream Members

        public void Write(string inHtml)
        {
            Console.WriteLine(inHtml);
        }

        #endregion
    }
}
