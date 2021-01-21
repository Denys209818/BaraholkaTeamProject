using BaraholkaTeamProject.DAL.ContextData;
using BaraholkaTeamProject.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaraholkaTeamProject
{
    public partial class MainForm : Form
    {
        public MyContext context { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.context = new MyContext();
            DBSeeder.SeedAll(this.context);
            Product product = this.context.products.First();

            this.pcBox.Image = Image.FromStream(new MemoryStream(product.image));
            this.lblNameProduct.Text = product.Name;
            this.lblProductDescription.Text = product.Description;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }
    }
}
