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

        private void AddNewCustomer_Button_Click(object sender, EventArgs e)
        {
            CustomerEditor addNewCustomerWindow = new CustomerEditor();
            addNewCustomerWindow.ShowDialog();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            CustomerEditor EditCustomerWindow = new CustomerEditor();
            EditCustomerWindow.ShowDialog();
        }

        private void AddObject_Button_Click(object sender, EventArgs e)
        {
            ObjectEditor objectEditor = new ObjectEditor();
            objectEditor.ShowDialog();
        }

        private void ShowObjects_Button_Click(object sender, EventArgs e)
        {
            // przenosi do zakładki z obiektami "Objects_TabPage", 
            // gdzie będą wyświetlone obiekty tego konkretnego klienta
        }

        private void SeeDetails_Button_Click(object sender, EventArgs e)
        {
            ObjectEditor objectEditor = new ObjectEditor("seeDatails");
            objectEditor.ShowDialog();
        }

        private void EditObject_Button_Click(object sender, EventArgs e)
        {
            ObjectEditor objectEditor = new ObjectEditor();
            objectEditor.ShowDialog();
        }

        private void AddRequest_Button_Click(object sender, EventArgs e)
        {
            RequestEditor requestEditor = new RequestEditor();
            requestEditor.ShowDialog();
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            RequestEditor requestEditor = new RequestEditor();
            requestEditor.ShowDialog();
        }

        private void ShowActivity_Button_Click(object sender, EventArgs e)
        {
            ActivityViever activityViever = new ActivityViever();
            activityViever.ShowDialog();
        }
    }
}
