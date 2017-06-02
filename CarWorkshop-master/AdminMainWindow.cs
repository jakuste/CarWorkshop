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
    public partial class AdminMainWindow : MainWindow
    {

        public AdminMainWindow()
        {
            InitializeComponent();
  
            this.FormClosing += X_Clickd;
        }

        private void X_Clickd(object sender, FormClosingEventArgs e)
        {
            //x clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.CloseApp(sender, e);
            }
        }

        private void AdminMainWindow_Load(object sender, EventArgs e)
        {

        }

    
        public override void InitOnShow()
        {
            this.WelcomeText_Label.Text = "Hi, you are logged in as ";
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            Program.loginWindow.Visible = true;
            this.Visible = false;
        }

        private void AddNewAccount_Button_Click(object sender, EventArgs e)
        {
            UserEditor addNewAccountWindow = new UserEditor();
            addNewAccountWindow.ShowDialog();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            UserEditor addNewAccountWindow = new UserEditor();
            addNewAccountWindow.ShowDialog();
        }
    }
}
