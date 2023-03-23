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
    public partial class CourrierCrud : Form
    {
        public CourrierCrud()
        {
            InitializeComponent();
        }

        private CourrierService _courrierService;
        private void CourrierCrud_Load(object sender, EventArgs e)
        {
            _courrierService = new CourrierService();
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
        private async void bttnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Courrier courrier = new Courrier();
                courrier.Name = txtAddName.Text;
                courrier.CourrierPhoneNumber = txtAddNum.Text;
                await _courrierService.CreateAsync(courrier);
                MessageBox.Show("Успешно създадохте нов куриер!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }
        private async void bttnEdit_Click(object sender, EventArgs e)
        {
            Courrier courrier = await _courrierService.GetCourrierByIdAsync(int.Parse(txtEditId.Text));

            courrier.Name = txtEditName.Text;
            courrier.CourrierPhoneNumber = txtEditNum.Text;

            var result = MessageBox.Show($"Напът сте да редактирате куриер с нови стойности {courrier.Id} {courrier.Name} {courrier.Name}. Желаете ли да продължите?", "Редактиране", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _courrierService.UpdateAsync(courrier);
                MessageBox.Show("Успешно редактирахте куриер!", "Успешна редакция");
            }
        }

        private async void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Courrier courrier = await _courrierService.GetCourrierByIdAsync(int.Parse(txtDeleteId.Text));

                var result = MessageBox.Show($"Изтриване на {courrier.Id} {courrier.Name} {courrier.CourrierPhoneNumber}? Това не може да бъде възстановено!", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await _courrierService.DeleteAsync(int.Parse(txtDeleteId.Text));
                }

                MessageBox.Show("Успешно изтрихте куриер!", "Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error");
            }
        }
    }
}
