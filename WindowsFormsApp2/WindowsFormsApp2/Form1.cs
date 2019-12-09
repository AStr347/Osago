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
        
        AbMenu osagoAddMenu = new OsagoAddMenu();
        AbMenu osagoViewMenu = new ViewOsagoMenu();
        AbMenu osagoViewDB = new ViewOsagoDB();

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

        private void ViewClick(object sender, EventArgs e)
        {
            reDraw();
            Controls.Add(osagoViewMenu.Draw());
        }

        private void ViewDBClick(object sender, EventArgs e)
        {
            reDraw();
            Controls.Add(osagoViewDB.Draw());
        }
    }
}
