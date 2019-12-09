using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    abstract class AbMenu
    {
        protected Panel MainPanel;

        public Control Draw()
        {
            return MainPanel;
        }
    }
}
