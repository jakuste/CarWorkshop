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
    public partial class WorkerMainWindow : MainWindow
    {
        public WorkerMainWindow()
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

        public override void InitOnShow()
        {
            this.WelcomeText_Label.Text = "Hi, you are logged in as [username]";
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            Program.loginWindow.Visible = true;
            this.Visible = false;
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            ActivityViever ShowActivityWindow = new ActivityViever();
            ShowActivityWindow.ShowDialog();
        }
    }
}
