using BaraholkaTeamProject.DAL.ContextData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
