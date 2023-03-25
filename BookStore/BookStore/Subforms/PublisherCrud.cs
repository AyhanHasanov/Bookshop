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
    public partial class PublisherCrud : Form
    {
        public PublisherCrud()
        {
            InitializeComponent();
        }
        private PublisherService _publisherService;
        private void PublisherCrud_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.logoICON;
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = true;
            var loc = new Point(0, 40);
            panelAdd.Location = loc;
            this.Size = panelAdd.Size;
            this.Height += 50;

            _publisherService = new PublisherService();

        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = true;
            var loc = new Point(0, 40);
            panelAdd.Location = loc;
            this.Size = panelAdd.Size;
            this.Height += 50;

        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = true;
            panelAdd.Visible = false;
            var loc = new Point(0, 40);
            panelEdit.Location = loc;
            this.Size = panelEdit.Size;
            this.Height += 50;

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            var loc = new Point(0, 40);
            panelDelete.Location = loc;
            this.Size = panelDelete.Size;
            this.Height += 50;

        }

        private async void AddBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher pub = new Publisher();
                pub.Name = txtAddName.Text;
                await _publisherService.CreateAsync(pub);

                MessageBox.Show("Успешно създадохте нов издател!", "Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private async void DeleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Publisher pub = await _publisherService.GetPublisherByIdAsync(int.Parse(txtDeleteId.Text));

                var result = MessageBox.Show($"Изтриване на {pub.Id} {pub.Name}? Това не може да бъде възстановено!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await _publisherService.DeleteAsync(int.Parse(txtDeleteId.Text));
                }

                MessageBox.Show("Успешно изтрихте издател!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private async void EditBttn_Click(object sender, EventArgs e)
        {
            Publisher pub = await _publisherService.GetPublisherByIdAsync(int.Parse(txtEditId.Text));

            pub.Name = txtEditName.Text;

            var result = MessageBox.Show($"Напът сте да редактирате издател с нови стойности {pub.Id} {pub.Name}! Желаете ли да продължите?", "Редактиране", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _publisherService.UpdateAsync(pub);
                MessageBox.Show("Успешно редактирахте издател!", "Успешна редакция");
            }
        }
    }
}
