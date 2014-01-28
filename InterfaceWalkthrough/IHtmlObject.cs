using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceWalkthrough
{
    public interface IHtmlObject
    {
        void Render(IHtmlStream inStream);
    }

    public interface IHtmlStream
    {
        void Write(string inHtml);
    }
}
