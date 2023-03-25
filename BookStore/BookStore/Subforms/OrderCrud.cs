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
    public partial class OrderCrud : Form
    {
        public OrderCrud()
        {
            InitializeComponent();
        }

        private BookCourrierService _orderService;
        private BookService _bookService;
        private CourrierService _courrierService;
        private async void OrderCrud_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.logoICON;
            _orderService = new BookCourrierService();
            _bookService = new BookService();
            _courrierService = new CourrierService();

            foreach (var book in await _bookService.GetAllBookAsync())
            {
                comboAddBook.Items.Add($"{book.Title} / {book.Author} / {book.Price}");
                comboEditBook.Items.Add($"{book.Title} / {book.Author} / {book.Price}");
            }

            foreach (var courrier in await _courrierService.GetAllCourriersAsync())
            {
                comboAddCurrier.Items.Add(courrier.Name);
                comboEditCourrier.Items.Add(courrier.Name);
            }

            button1_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = true;
            var loc = new Point(0, 40);
            panelAdd.Location = loc;
            this.Size = panelAdd.Size;
            this.Height += 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            var loc = new Point(0, 40);
            panelEdit.Location = loc;
            this.Size = panelEdit.Size;
            this.Height += 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelDelete.Visible = true;
            panelAdd.Visible = false;
            var loc = new Point(0, 40);
            panelDelete.Location = loc;
            this.Size = panelDelete.Size;
            this.Height += 50;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string bookName = comboAddBook.SelectedItem.ToString().Split('/').First().TrimEnd().ToString();
                    
                Book book = await _bookService.GetBookByTitleAsync(bookName);

                string courrierName = comboAddCurrier.SelectedItem.ToString();
                Courrier courrier = await _courrierService.GetCourrierByNameAsync(courrierName);

                if (int.Parse(txtAddQuantity.Text) <= book.Quantity)
                {
                    book.Quantity -= int.Parse(txtAddQuantity.Text);
                    await _bookService.UpdateAsync(book);

                    BookCourrier newOrder = new BookCourrier();
                    newOrder.CourrierId = courrier.Id;
                    newOrder.BookId = book.BookId;
                    newOrder.DeliveryDate = dateTimePicker1.Value;
                    newOrder.Quantity = int.Parse(txtAddQuantity.Text);

                    await _orderService.CreateAsync(newOrder);
                    MessageBox.Show("Успешно създадохте нова поръчка!", "Success");
                
                }
                else
                    throw new ArgumentException();
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private async void bttnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEditId.Text);
            BookCourrier order = await _orderService.GetBookCourrierByIdAsync(id);

            Book oldBook = await _bookService.GetBookByIdAsync(order.BookId);

            string bookName = comboEditBook.SelectedItem.ToString().Split('/').First().TrimEnd().ToString();
            Book book = await _bookService.GetBookByTitleAsync(bookName);

            string courrierName = comboEditCourrier.SelectedItem.ToString();
            Courrier courrier = await _courrierService.GetCourrierByNameAsync(courrierName);

            if (int.Parse(txtEditQuantity.Text) <= book.Quantity)
            {
                oldBook.Quantity += order.Quantity;
                book.Quantity -= int.Parse(txtEditQuantity.Text);

                order.CourrierId = courrier.Id;
                order.BookId = book.BookId;
                order.DeliveryDate = dateTimePicker1.Value;
                order.Quantity = int.Parse(txtEditQuantity.Text);

                await _orderService.UpdateAsync(order);
                await _bookService.UpdateAsync(book);

                MessageBox.Show("Успешно редактирахте поръчка!", "Success");
            }
            else
                throw new ArgumentException();

        }

        private async void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BookCourrier order = await _orderService.GetBookCourrierByIdAsync(int.Parse(txtDeleteId.Text));
                Book book = await _bookService.GetBookByIdAsync(order.BookId);
                book.Quantity += order.Quantity;
                await _bookService.UpdateAsync(book);
                
                var result = MessageBox.Show($"Изтриване на {order.OrderID}? Това не може да бъде възстановено!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    await _orderService.DeleteAsync(order.OrderID);
                }

                MessageBox.Show("Успешно изтрихте поръчка!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }
    }
}
