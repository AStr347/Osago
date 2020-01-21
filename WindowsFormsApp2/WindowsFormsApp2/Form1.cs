using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyOsago;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        AddOsago AddOsago = new AddOsago();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddOsago.ShowDialog();
        }

        private void ViewClick(object sender, EventArgs e)
        {
            
            
        }

        private void ViewDBClick(object sender, EventArgs e)
        {
            
            
        }
    }
}
