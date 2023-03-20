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

        private void Form1_Load(object sender, EventArgs e)
        {
            //var publisherService = new PublisherService();

            //Publisher pub = new Publisher()
            //{
            //    Name = "Ciela"
            //};

            //try
            //{
            //    publisherService.CreateAsync(pub);
            //    MessageBox.Show("Success");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //}
        }
    }
}
