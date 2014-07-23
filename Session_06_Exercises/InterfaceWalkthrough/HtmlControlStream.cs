using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceWalkthrough
{
    class HtmlControlStream : IHtmlStream
    {
        private string mHtml = "";
        public WebBrowser Browser;

        #region IHtmlStream Members

        public void Write(string inHtml)
        {
            mHtml += inHtml;

            Browser.Navigate("about:blank");
            if (Browser.Document != null)
            {
                Browser.Document.Write(string.Empty);
            }
            Browser.DocumentText = mHtml;
        }

        #endregion
    }
}
