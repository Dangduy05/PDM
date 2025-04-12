using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using PDMcustom.ChildForm;

namespace PDMcustom
{
    public partial class Main : Form
    {
        private Form currentChildForm;


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Login"];

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                //lblTitleChildForm.Text = childForm.Text;
            }
            else
            {
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        public Main()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnUser.Text = ((Login)f).tbUsername.Text;
            if (btnUser.Text.Length >= 20)
            {
                btnUser.Font = new Font(btnUser.Font.FontFamily, 10);
            }
        }

        //private void Main_Load(object sender, EventArgs e)
        //{
        //    if (f != null && f.Controls["tbUsername"] != null && btnUser != null)
        //    {
        //        btnUser.Text = f.Controls["tbUsername"].Text;
        //    }
        //    else
        //    {
        //        // Handle the case where one of the objects is null
        //        MessageBox.Show("One or more controls are not properly initialized.");
        //    }
        //}

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (flpSidebar.Width == flpSidebar.MaximumSize.Width)
            //{
            //    flpSidebar.Width = flpSidebar.MinimumSize.Width;
            //}
            //else
            //{
            //    flpSidebar.Width = flpSidebar.MaximumSize.Width;
            //}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnManageDocument_Click(object sender, EventArgs e)
        {
            //if(panelManageDocument.MinimumSize.Height == panelManageDocument.Height)
            //{
            //    panelManageDocument.Height = panelManageDocument.MaximumSize.Height;
            //}
            //else
            //{
            //    panelManageDocument.Height = panelManageDocument.MinimumSize.Height;
            //}
            openChildForm(new AddRecord());
        }

        private void btnNumberRule_Click(object sender, EventArgs e)
        {

        }

        private void btvVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if(flpVerifyDocument.MinimumSize.Height == flpVerifyDocument.Height)
            {
                flpVerifyDocument.Height = flpVerifyDocument.MaximumSize.Height;
            }
            else
            {
                flpVerifyDocument.Height = flpVerifyDocument.MinimumSize.Height;
            }
        }

        private void btnTool_Click(object sender, EventArgs e)
        {

        }
        //private void Scale()
        //{
            
        //    s.Dock = DockStyle.Fill;
        //}
        

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Classify());
        }

        private void btnManageProject_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProject());
        }

        /*
private void btnDrive_Click(object sender, EventArgs e)
{
string[] Scopes = { DriveService.Scope.DriveReadonly };
string ApplicationName = "PDMcustom";

UserCredential credential;

using (var stream =
new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
{
string credPath = "token.json";
credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
  GoogleClientSecrets.Load(stream).Secrets,
  Scopes,
  "user",
  CancellationToken.None,
  new FileDataStore(credPath, true)).Result;
}

// Create Drive API service.
var service = new DriveService(new BaseClientService.Initializer()
{
HttpClientInitializer = credential,
ApplicationName = ApplicationName,
});

// Define parameters of request.
FilesResource.ListRequest listRequest = service.Files.List();
listRequest.PageSize = 10;
listRequest.Fields = "nextPageToken, files(id, name)";

// List files.
var request = listRequest.Execute();
var files = request.Files;
if (files != null && files.Count > 0)
{
foreach (var file in files)
{
  Console.WriteLine("{0} ({1})", file.Name, file.Id);
}
}
else
{
Console.WriteLine("No files found.");
}
} */
    }
}
