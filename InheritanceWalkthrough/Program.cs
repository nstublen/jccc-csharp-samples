using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InheritanceWalkthrough
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // We create a book and a movie.  Setting the Code property
            // will allow us to step into the Product class implementation
            // for the set block of the Code property, but the code
            // validation will use the version of ValidateCode that is
            // specific to each object type.

            Book book = new Book();
            book.Code = "BK0001";

            Movie movie = new Movie();
            movie.Code = "MV0001";

            // Polymorphism allows us to treat objects derived from Product
            // as though they are Product objects.

            List<Product> products = new List<Product>();
            products.Add(book);
            products.Add(movie);

            foreach (Product p in products)
            {
                Console.WriteLine(p.GetType().ToString() + ": Code = " + p.Code);
            }
        }
    }
}
