using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfaceWalkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Code = "BK0001";
            book.Name = "The Joys of C#";
            book.Price = 14.95m;

            Movie movie = new Movie();
            movie.Code = "MV0001";
            movie.Name = "C# In Living Color";
            movie.Price = 39.99m;

            List<IHtmlObject> htmlObjects = new List<IHtmlObject>();
            htmlObjects.Add(book);
            htmlObjects.Add(movie);

            // We have two implementations of IHtmlStream and we
            // send either of them to any object that implements
            // the IHtmlObject interface.

            HtmlConsoleStream stream1 = new HtmlConsoleStream();
            HtmlControlStream stream2 = new HtmlControlStream();
            stream2.Browser = webBrowser1;

            stream2.Write("<html><body>");
            foreach (IHtmlObject obj in htmlObjects)
            {
                obj.Render(stream1);
                obj.Render(stream2);
            }
            stream2.Write("</body></html>");
        }
    }
}
