using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        OsagoAddMenu osagoAddMenu = new OsagoAddMenu();


        public Form1()
        {
            InitializeComponent();
        }

        private void reDraw() {
            Controls.Clear();
            this.Controls.Add(this.menuStrip1);
        }

        private void AddClick(object sender, EventArgs e)
        {
            reDraw();
            Controls.Add(osagoAddMenu.Draw());
        }
    }
}
