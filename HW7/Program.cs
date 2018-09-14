using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Author author = new Author
            {
                FirstName = "Isaac",
                LastName = "Azimov"
            };
            AddAuthor(author);
            GetAllAuthors();
        }

        static void AddAuthor(Author author)
        {
            using (Library7Entities db = new Library7Entities())
            {
                db.Author.Add(author);
                db.SaveChanges();
                Console.WriteLine("New author added:" +
                author.LastName);
            }
        }
        static void GetAllAuthors()
        {
            using (Library7Entities db = new Library7Entities())
            {
                var au = db.Author.ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " +
                    a.LastName);
                }
            }
        }

    }
}
