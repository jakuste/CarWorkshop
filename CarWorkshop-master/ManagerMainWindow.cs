﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace CarWorkshop
{
    public partial class ManagerMainWindow : MainWindow
    {
        private Personel user;

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
            if((Client)Customers_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            CustomerEditor EditCustomerWindow = new CustomerEditor((Client)Customers_DataGridView.CurrentRow.DataBoundItem);
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
            if ((Client)Customers_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            DataLayer.Object obj = new DataLayer.Object();
            obj.id_client = ((Client)Customers_DataGridView.CurrentRow.DataBoundItem).id_client;
            GetObjects(obj);
            //ManagerMainWindow_TabControl.
        }

        // Get object from database and display
        private void GetObjects(DataLayer.Object obj)
        {
            try
            {
                var result = ManagerService.GetObjects(obj);

                Objects_DataGridView.DataSource = (from ob in result select new {Name = ob.Client.name}).ToList();

                Objects_DataGridView.Columns[0].Visible = false;
                //Objects_DataGridView.Columns[7].Visible = false;
                //Objects_DataGridView.Columns[8].Visible = false;

                Objects_DataGridView.Columns[1].HeaderText = "Name";
                //Objects_DataGridView.Columns[2].HeaderText = "Surname";
                //Objects_DataGridView.Columns[3].HeaderText = "Street";
                //Objects_DataGridView.Columns[4].HeaderText = "Number";
                //Objects_DataGridView.Columns[5].HeaderText = "City";
                //Objects_DataGridView.Columns[6].HeaderText = "Country";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void SeeDetails_Button_Click(object sender, EventArgs e)
        {
            EditObject_Button_Click(sender, e);
        }

        private void EditObject_Button_Click(object sender, EventArgs e)
        {
            if ((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            //ObjectEditor objectEditor = new ObjectEditor((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem);
            //objectEditor.ShowDialog();
        }

        private void AddRequest_Button_Click(object sender, EventArgs e)
        {
            if ((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            RequestEditor requestEditor = new RequestEditor((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem);
            requestEditor.ShowDialog();
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            if ((Request)Requests_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            RequestEditor requestEditor = new RequestEditor((Request)Requests_DataGridView.CurrentRow.DataBoundItem);
            requestEditor.ShowDialog();
        }

        private void ShowActivity_Button_Click(object sender, EventArgs e)
        {
            ActivityViever activityViever = new ActivityViever();
            activityViever.ShowDialog();
        }

        private void SearchCustomers_Button_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if(Company_CheckBox.Checked)
            {
                client.name = Name_TextBox.Text;
            }
            else
            {
                client.first_name = Name_TextBox.Text;
                client.last_name = Surname_TextBox.Text;
            }
            client.city = City_TextBox.Text;
            try
            {
                var result = ManagerService.GetClients(client);
                Customers_DataGridView.DataSource = result.ToList();

                Customers_DataGridView.Columns[0].Visible = false;
                Customers_DataGridView.Columns[7].Visible = false;
                Customers_DataGridView.Columns[8].Visible = false;

                Customers_DataGridView.Columns[1].HeaderText = "Name";
                Customers_DataGridView.Columns[2].HeaderText = "Surname";
                Customers_DataGridView.Columns[3].HeaderText = "Street";
                Customers_DataGridView.Columns[4].HeaderText = "Number";
                Customers_DataGridView.Columns[5].HeaderText = "City";
                Customers_DataGridView.Columns[6].HeaderText = "Country";
            }
            catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Objects_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchObjects_Button_Click(object sender, EventArgs e)
        {
            DataLayer.Object obj = new DataLayer.Object();
            obj.name = Name_TextBox.Text;
            obj.manufacturer = Manufacturer_TextBox.Text;
            obj.registration_number = Int32.Parse(RegistrationNo_TextBox.Text);
            obj.model = Model_TextBox.Text;
            GetObjects(obj);
        }

        private void DeleteCustomer_Button_Click(object sender, EventArgs e)
        {
            if ((Client)Customers_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                ManagerService.DeleteClient((Client)Customers_DataGridView.CurrentRow.DataBoundItem);
                Customers_DataGridView.CurrentRow.Visible = false;
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void DeleteObject_Button_Click(object sender, EventArgs e)
        {
            if ((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                ManagerService.DeleteObject((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem);
                Objects_DataGridView.CurrentRow.Visible = false;
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void ShowRequests_Button_Click(object sender, EventArgs e)
        {
            if ((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            Request request = new Request();
            request.id_object = ((DataLayer.Object)Objects_DataGridView.CurrentRow.DataBoundItem).id_object;
            GetRequests(request);
        }

        private void GetRequests(Request request)
        {
            try
            {
                var result = ManagerService.GetRequests(request);

                Objects_DataGridView.DataSource = result.ToList();

                Objects_DataGridView.Columns[0].Visible = false;
                Objects_DataGridView.Columns[7].Visible = false;
                Objects_DataGridView.Columns[8].Visible = false;

                Objects_DataGridView.Columns[1].HeaderText = "Seq Nr";
                Objects_DataGridView.Columns[2].HeaderText = "Name";
                Objects_DataGridView.Columns[3].HeaderText = "Description";
                Objects_DataGridView.Columns[4].HeaderText = "Date Request";
                Objects_DataGridView.Columns[5].HeaderText = "Time Out";
                Objects_DataGridView.Columns[6].HeaderText = "Status";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void SearchRequests_Button_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.date_request = RequestDate_DateTimePicker.Value;
            request.status = RequestStatus_ComboBox.Text;
            GetRequests(request);
        }

        private void SearchActivities_Button_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.date_fin_cancel = ActivityDate_DateTimePicker.Value;
            activity.status = ActivityStatus_ComboBox.Text;
            if(ShowOnlyMyActivities_CheckBox.Checked)
            {
                activity.id_personel = user.id_personel;
            }
            GetActivities(activity);
        }

        private void GetActivities(Activity activity)
        {
            //TODO
        }
    }
}
