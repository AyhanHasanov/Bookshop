using BookStore.Data.Models;
using BookStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Subforms
{
    public partial class QueriesForm: Form
    {
        public QueriesForm()
        {
            InitializeComponent();
        }
        private BookService _bookService;
        private BookCourrierService _orderService;
        private CourrierService _courrierService;
        private async void QueriesForm_Load(object sender, EventArgs e)
        {
            _bookService = new BookService();
            _orderService = new BookCourrierService();
            _courrierService = new CourrierService();

            FindAndDisplayMostExpensiveBook();
            DisplayBookNameAuthorAndCourrier();
        }

        private async void DisplayBookNameAuthorAndCourrier()
        {
            foreach (var order in await _orderService.GetAllBookCourriersAsync())
            {
                Book book = await _bookService.GetBookByIdAsync(order.BookId);
                Courrier courrier = await _courrierService.GetCourrierByIdAsync(order.CourrierId);

                lstBox3.Items.Add($"\"{book.Title}\"");
                lstBox3.Items.Add($"{book.Author}");
                lstBox3.Items.Add($"{courrier.Name}");
                lstBox3.Items.Add(" ");
            }
        }

        private async void FindAndDisplayMostExpensiveBook()
        {
            Book mostExpensive = null;
            double priceController = int.MinValue;

            foreach (var book in await _bookService.GetAllBookAsync())
            {
                combo1Books.Items.Add($"{book.Title} - {book.Author}");
                if (book.Price > priceController)
                {
                    mostExpensive = book;
                    priceController = book.Price;
                }
            }


            lblMostExpensive.Text = $"Най-скъпата книга е:\n\"{mostExpensive.Title}\"\n" +
                $"от {mostExpensive.Author}\n" +
                $"с цена {mostExpensive.Price:f2} BGN, \n" +
                $"издадена през {mostExpensive.Created.ToString("yyyy")}\n" +
                $"от ид издател {mostExpensive.PublisherId} и\n" +
                $"налично количество - {mostExpensive.Quantity}";
        }

        private void qeuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }
        private void query2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void query3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void query4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void query5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage5);
        }

        private void query6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookName = combo1Books.SelectedItem.ToString().Split('-').First().TrimEnd().ToString();
            Book book = await _bookService.GetBookByTitleAsync(bookName);
            lbl1Price.Text = $"{book.Price:f2} лв";
        }

       
    }
}
