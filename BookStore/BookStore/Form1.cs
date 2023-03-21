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

        private async void Form1_Load(object sender, EventArgs e)
        {
            var publisherService = new PublisherService();
            var courrierService = new CourrierService();

            //Publisher pub = new Publisher()
            //{
            //    Name = "Ciela"
            //};

            //try
            //{
            //    await publisherService.CreateAsync(pub);
            //    pub.Name = "Updated";
            //    await publisherService.UpdateAsync(pub);
            //    await publisherService.GetAllPublisherAsync();
            //    await publisherService.GetPublisherByIdAsync(2);
            //    await publisherService.DeleteAsync(2);
            //    MessageBox.Show("Success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //}

            Courrier cou = new Courrier()
            {
                Name = "Econt"
            };

            try
            {
                await courrierService.DeleteAsync(2);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
