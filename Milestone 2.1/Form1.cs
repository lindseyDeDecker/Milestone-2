using System.Diagnostics.Eventing.Reader;

/*
 * Lindsey DeDecker
 * CST - 150
 * Milestone 2
 * July 7, 2024
 * TutorialsTeacher. 2024, July 7. c# - List<T>. TutorialsTeacher. https://www.tutorialsteacher.com/csharp/csharp-list.
 * Gaddis, T. (2019). Starting out with Visual C# (5th ed.). Pearson. ISBN-13: 9780135183519.
 * W3schools. 2024, July 7. C# Foreach Loop. W3schools. https://www.w3schools.com/cs/cs_foreach_loop.php.
 */

namespace Milestone_2._1
{
    public partial class inventoryForm : Form
    {
        public inventoryForm()
        {
            InitializeComponent();
            //Make the label for inventory not visible
            lblInventory.Visible = false;
            lblTitle.Visible = false;
        }

        private void inventoryForm_Load(object sender, EventArgs e)
        {

        }
        public class Book
        {
            //Create attributes of the class book
            private string title = "";
            private string author = "";
            private double quantity;
            private double price;

            //getters and setters for the varaibles I want for the books
            public string Title
            {
                get { return title; }
                set { title = value; }

            }
            public string Author
            {
                get { return author; }
                set { author = value; }

            }
            public double Quantity
            {
                get { return quantity; }
                set { quantity = value; }

            }
            public double Price
            {
                get { return price; }
                set { price = value; }

            }
        }
        static string DisplayBooks()
        {
            string Output = "";

            //Setting a book list

            List<Book> books = new List<Book>();

            //Creating initial books

            Book Book1 = new Book();
            Book1.Title = "On Call: A Doctor's Journey in Public Service";
            Book1.Author = "Anthony Fauci";
            Book1.Quantity = 5;
            Book1.Price = 22.59;
            books.Add(Book1);

            Book Book2 = new Book();
            Book2.Title = "A Court of Thorns and Roses";
            Book2.Author = "Sarah J. Mass";
            Book2.Quantity = 7;
            Book2.Price =28.99;
            books.Add(Book2);

            Book Book3 = new Book();
            Book3.Title = "The Housemaid";
            Book3.Author = "Freida McFadden";
            Book3.Quantity = 4;
            Book3.Price = 14.99;
            books.Add(Book3);

            Book Book4 = new Book();
            Book4.Title = "Swan Song";
            Book4.Author = "Elin Hilderbrand";
            Book4.Quantity = 8;
            Book4.Price = 16.99;
            books.Add(Book4);

            Book Book5 = new Book();
            Book5.Title = "The Anxious Generation";
            Book5.Author = "Jonathan Haidt";
            Book5.Quantity = 3;
            Book5.Price = 23.99;
            books.Add(Book5);

            //The Book array list will be printed. 
            foreach (Book book in books)
            {
                Output += (book.Title + "     " + book.Author + "     " + book.Quantity + "     " + book.Price + "\n");
            }
            return Output;
        }


        private void lblInventory_Click(object sender, EventArgs e)
        {

            //The label for the inventory will be displayed
            lblInventory.Visible = true;
            lblTitle.Visible = true;

            lblTitle.Text = "Books are displayed as: Title, Author, Quantity, Price";

            lblInventory.Text = DisplayBooks();


        }

        private void lblInventory_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
