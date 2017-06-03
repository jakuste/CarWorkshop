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
    public partial class ManagerMainWindow : MainWindow
    {
        public ManagerMainWindow()
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

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.loginWindow.Visible = true;
        }

        public override void InitOnShow()
        {
            this.WelcomeText_Label.Text = "Hi, you are logged in as [username]";
        }

    }
}
