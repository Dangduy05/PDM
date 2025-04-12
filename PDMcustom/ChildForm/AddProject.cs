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
    public partial class AddProject : Form
    {
        private Form currentChildForm;
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                //currentChildForm = childForm;
                //childForm.TopLevel = false;
                //childForm.FormBorderStyle = FormBorderStyle.None;
                //childForm.Dock = DockStyle.Fill;
                //panelAttachment.Controls.Add(childForm);
                //panelAttachment.Tag = childForm;
                //childForm.BringToFront();
                //childForm.Show();
                //lblTitleChildForm.Text = childForm.Text;
            }
            else
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelAttachment.Controls.Add(childForm);
                panelAttachment.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        public AddProject()
        {
            InitializeComponent();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            //Browse local file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Document Files|*.docx;*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //labelLocal.Text = ofd.FileName;
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            openChildForm(new Attachment());
        }
    }
}
