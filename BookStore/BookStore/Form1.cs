using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Data.Models;
using BookStore.Services;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PublisherService publisherService = new PublisherService();
        private CourrierService courrierService = new CourrierService();
        private BookService bookService = new BookService();
        private BookCourrierService bookCourrierService = new BookCourrierService();
        private async void Form1_Load(object sender, EventArgs e)
        {
            
            panelHome.Location = new Point(0, 0);
            panelTables.Location = new Point(0, 0);
            this.Size = panelHome.Size;
            panelTables.Visible = false;

           
            //panelHome.BackColor = Color.Red;
            //panelTables.BackColor = Color.Blue;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = panelTables.Size;
            this.Height += 20;
            panelHome.Visible = false;
            panelTables.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = panelHome.Size;
            panelHome.Visible = true;
            panelTables.Visible = false;
        }

        private async void bttnRaw_Click(object sender, EventArgs e)
        {
            lstBoxCourriers.Items.Clear();
            lstBoxPublishers.Items.Clear();
            lstBoxOrders.Items.Clear();
            lstBoxBooks.Items.Clear();
            
            foreach (var book in await bookService.GetAllBookAsync())
            {
                lstBoxBooks.Items.Add($"ID: {book.BookId}");
                lstBoxBooks.Items.Add($"Заглавие: \"{book.Title}\"");
                lstBoxBooks.Items.Add($"Автор: {book.Author}");
                lstBoxBooks.Items.Add($"Дата на издаване: {book.Created.Year}");
                lstBoxBooks.Items.Add($"Цена: {book.Price:f2}");
                var publisher = await publisherService.GetPublisherByIdAsync(book.PublisherId);
                lstBoxBooks.Items.Add($"Издателство: {publisher.Name}");
                lstBoxBooks.Items.Add(" ");
            }

            foreach (var publisher in await publisherService.GetAllPublisherAsync())
            {
                lstBoxPublishers.Items.Add($"ID: {publisher.Id}");
                lstBoxPublishers.Items.Add($"Име: {publisher.Name}");
                lstBoxPublishers.Items.Add($"");
            }

            foreach (var courrier in await courrierService.GetAllCourriersAsync())
            {
                lstBoxCourriers.Items.Add($"ID: {courrier.Id}");
                lstBoxCourriers.Items.Add($"Име: {courrier.Name}");
                lstBoxCourriers.Items.Add($"");
            }

            foreach (var order in await bookCourrierService.GetAllBookCourriersAsync())
            {
                lstBoxOrders.Items.Add($"Order ID: {order.OrderID}");
                var book = await bookService.GetBookByIdAsync(order.BookId);

                lstBoxOrders.Items.Add($"Book ID/Title: {book.BookId} / {book.Title}");
                var courrier = await courrierService.GetCourrierByIdAsync(order.CourrierId);
                
                lstBoxOrders.Items.Add($"Courrier ID/Name: {courrier.Id} / {courrier.Name}");
                lstBoxOrders.Items.Add($"Courrier Phone Number: {order.CourrierPhoneNumber}");
                lstBoxOrders.Items.Add($"Delivery date: {order.DeliveryDate.Date}");
                lstBoxOrders.Items.Add($"");
            }
        }
    }
}
