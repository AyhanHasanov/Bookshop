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
        private PublisherService _publisherService;
        private async void QueriesForm_Load(object sender, EventArgs e)
        {
            _bookService = new BookService();
            _orderService = new BookCourrierService();
            _courrierService = new CourrierService();
            _publisherService = new PublisherService();

            await FindAndDisplayMostExpensiveBook();
            await DisplayBookNameAuthorAndCourrier();
            await DisplayBookWithPriceBetween15And35();
        }

        private async Task<bool> DisplayBookWithPriceBetween15And35()
        {

            try
            {
                foreach (var order in await _orderService.GetAllBookCourriersAsync())
                {
                    Book book = await _bookService.GetBookByIdAsync(order.BookId);
                    Courrier courrier = await _courrierService.GetCourrierByIdAsync(order.CourrierId);
                    //Publisher publisher = await _publisherService.GetPublisherByIdAsync(book.PublisherId);

                    if (book.Price >= 15 && book.Price <= 35)
                    {
                        lstBox6.Items.Add($"ID {book.BookId}: \"{book.Title}\"");
                        lstBox6.Items.Add($"{book.Author}");
                        lstBox6.Items.Add($"{book.Price:f2}");
                        lstBox6.Items.Add($"{courrier.Name}"); ;
                        lstBox6.Items.Add($"{order.DeliveryDate}");
                        lstBox6.Items.Add($"{courrier.CourrierPhoneNumber}");
                        lstBox6.Items.Add($"");

                    }
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> DisplayBookNameAuthorAndCourrier()
        {
            try
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
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> FindAndDisplayMostExpensiveBook()
        {
            try
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
                return true;

            }
            catch (Exception)
            {
                return false;
            }
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
