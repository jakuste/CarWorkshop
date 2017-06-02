using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Program.loginWindow = this;
            this.AcceptButton = Login_Button;
            this.FormClosing += Program.CloseApp;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string adminText = "admin";
            string managerText = "manager";
            //this.Username_TextBox.Text = managerText;
            MainWindow mainWindow;
            if (this.Username_TextBox.Text == adminText)
            {
                mainWindow = new AdminMainWindow();
            }
            else if (this.Username_TextBox.Text == managerText)
            {
                mainWindow = new ManagerMainWindow();    
            }
            else
            {
                mainWindow = new WorkerMainWindow();
            }
            Program.mainWindow = mainWindow;
            mainWindow.InitOnShow();

            this.Visible = false;
            mainWindow.ShowDialog();
        }
    }
}
