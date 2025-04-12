using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDMcustom.ChildForm
{
    public partial class Classify : Form
    {
        public Classify()
        {
            InitializeComponent();
        }

            private void btnFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Visible)
            {
                panelFilter.Visible = false;
            }
            else
            {
                panelFilter.Visible = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
