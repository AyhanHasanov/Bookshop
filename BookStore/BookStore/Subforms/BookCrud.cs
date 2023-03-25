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
    public partial class BookCrud : Form
    {
        public BookCrud()
        {
            InitializeComponent();
        }

        private BookService _bookService;
        private PublisherService _publisherService;
        private async void BookCrud_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.logoICON;
            chckAllBooks.Checked = true;
            txtChangePriceBookId.Enabled = false;
            _bookService = new BookService();
            _publisherService = new PublisherService();
            
            foreach (var pub in await _publisherService.GetAllPublisherAsync())
            {
                comboBox1.Items.Add(pub.Name);
                comboBox2.Items.Add(pub.Name);
            }

            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            panelPrice.Visible = false;
            var loc = new Point(0, 40);
            panelAdd.Location = loc;
            this.Size = panelAdd.Size;
            this.Height += 50;
        }

        private async void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book();
                newBook.Title = txtTitle.Text;
                newBook.Author = txtAuthor.Text;
                newBook.Price = float.Parse(txtPrice.Text);
                newBook.Quantity = int.Parse(txtQuantity.Text);
                newBook.Created = dateTimePicker1.Value;

                string publisherName = comboBox1.SelectedItem.ToString();
                Publisher publisher = await _publisherService.GetPublisherByNameAsync(publisherName);

                if (publisher != null)
                {
                    newBook.PublisherId = publisher.Id;
                }

                await _bookService.CreateAsync(newBook);
                MessageBox.Show("Успешно създадохте нова книга!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private async void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBoxDelete.Text);
                var book = await _bookService.GetBookByIdAsync(id);
                var result = MessageBox.Show($"Изтриване на {book.BookId} {book.Title} {book.Author} {book.Price} {book.Created}? Това не може да бъде възстановено!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await _bookService.DeleteAsync(id);
                }

                MessageBox.Show("Успешно изтрихте книга!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
            
        }

        private async void bttnEdit_Click(object sender, EventArgs e)
        {
            Book book = await _bookService.GetBookByIdAsync(int.Parse(txtBoxEditId.Text));
            
            book.Title = txtBoxEditName.Text;
            book.Author = txtBoxEditAuthor.Text;
            book.Price = float.Parse(txtBoxEditPrice.Text);
            book.Quantity = int.Parse(txtBoxEditQuantity.Text);
            book.Created = dateTimePicker2.Value;

            string publisherName = comboBox2.SelectedItem.ToString();
            Publisher publisher = await _publisherService.GetPublisherByNameAsync(publisherName);

            if (publisher != null)
            {
                book.PublisherId = publisher.Id;
            }

            var result = MessageBox.Show($"Напът сте да редактирате книгата с нови стойности {book.BookId} {book.Title} {book.Author} {book.Price} {book.Created}. Желаете ли да продължите?", "Редактиране", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _bookService.UpdateAsync(book);
                MessageBox.Show("Успешно редактирахте книга!", "Успешна редакция");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = true;
            panelPrice.Visible = false;
            var loc = new Point(0, 40);
            panelAdd.Location = loc;
            this.Size = panelAdd.Size;
            this.Height += 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = true;
            panelAdd.Visible = false;
            panelPrice.Visible = false;
            var loc = new Point(0, 40);
            panelEdit.Location = loc;
            this.Size = panelEdit.Size;
            this.Height += 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            panelPrice.Visible = false;
            var loc = new Point(0, 40);
            panelDelete.Location = loc;
            this.Size = panelDelete.Size;
            this.Height += 50;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            panelPrice.Visible = true;
            var loc = new Point(0, 40);
            panelPrice.Location = loc;
            this.Size = panelPrice.Size;
            this.Height += 50;
        }

        private void radioIncrease_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDecrease_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chckAllBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAllBooks.Checked == false)
                txtChangePriceBookId.Enabled = true;
            else
                txtChangePriceBookId.Enabled = false;
        }

        private async void bttnChangePrice_Click(object sender, EventArgs e)
        {
            try
            {
                double percantage = double.Parse(txtPercentage.Text) / 100;
                if (percantage < 0 || percantage > 1)
                {
                    throw new ArgumentOutOfRangeException("Процентът трябва да е между 1 и 100 включително.");
                }

                if (radioIncrease.Checked)
                {
                    if (chckAllBooks.Checked)
                    {
                        foreach (var book in await _bookService.GetAllBookAsync())
                        {
                            book.Price += (book.Price * percantage);
                            await _bookService.UpdateAsync(book);
                        }
                    }
                    else
                    {
                        Book book = await _bookService.GetBookByIdAsync(int.Parse(txtChangePriceBookId.Text));
                        if (book != null)
                        {
                            book.Price += (book.Price * percantage);
                            await _bookService.UpdateAsync(book);
                        }
                        else
                        {
                            throw new ArgumentNullException("Няма такава книга в базата данни!");
                        }
                    }
                }
                else if (radioDecrease.Checked)
                {
                    if (chckAllBooks.Checked)
                    {
                        foreach (var book in await _bookService.GetAllBookAsync())
                        {
                            var priceAfterSale = book.Price - (book.Price * percantage);
                            if (priceAfterSale < 0)
                            {
                                throw new ArgumentOutOfRangeException("Цената на книгата не може да е 0 лв след разпродажба! Актуализирането на цените е прекратено!");
                            }
                            else
                            {
                                book.Price = priceAfterSale;
                                await _bookService.UpdateAsync(book);
                            }
                        }
                    }
                    else
                    {
                        Book book = await _bookService.GetBookByIdAsync(int.Parse(txtChangePriceBookId.Text));
                        book.Price -= (book.Price * percantage);
                        await _bookService.UpdateAsync(book);
                    }
                }

                MessageBox.Show("Успешно променихте цената на книга/книги.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
