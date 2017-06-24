using System;
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
    public partial class RequestEditor : Form
    {
        private Request request = null;
        private DataLayer.Object obj = null;
        public RequestEditor(DataLayer.Object obj)
        {
            InitializeComponent();
            this.obj = obj;
            BodyType_TextBox.Text = obj.body_type;
            Name_TextBox.Text = obj.name;
            Engine_TextBox.Text = obj.engine;
            Manufacturer_TextBox.Text = obj.manufacturer;
            Year_TextBox.Text = obj.year.ToString();
            Model_TextBox.Text = obj.model;
            Other_TextBox.Text = obj.other;
            RegistrationNumber_TextBox.Text = obj.registration_number;

            AddActivity_Button.Enabled = false;
            DeleteActivity_Button.Enabled = false;
        }

        public RequestEditor(Request request)
        {
            InitializeComponent();
            this.request = request;
            RegistrationNumber_TextBox.Text = request.Object.registration_number;
            BodyType_TextBox.Text = request.Object.body_type;
            Name_TextBox.Text = request.Object.name;
            Engine_TextBox.Text = request.Object.engine;
            Manufacturer_TextBox.Text = request.Object.manufacturer;
            Year_TextBox.Text = request.Object.year.ToString();
            Model_TextBox.Text = request.Object.model;
            Other_TextBox.Text = request.Object.other;
            Description_TextBox.Text = request.description;

            Activity activity = new Activity();
            activity.id_request = request.id_request;
            try
            {
                var result = ManagerService.GetActivities(activity);
                Activities_DataGridView.Columns.Clear();
                Activities_DataGridView.DataSource = result.ToList();

                Activities_DataGridView.Columns[0].Visible = false;
                Activities_DataGridView.Columns[3].Visible = false;
                Activities_DataGridView.Columns[7].Visible = false;
                Activities_DataGridView.Columns[8].Visible = false;
                Activities_DataGridView.Columns[9].Visible = false;

                Activities_DataGridView.Columns[1].HeaderText = "Seq";
                Activities_DataGridView.Columns[2].HeaderText = "Description";
                Activities_DataGridView.Columns[4].HeaderText = "Date Request";
                Activities_DataGridView.Columns[5].HeaderText = "Date Finish";
                Activities_DataGridView.Columns[6].HeaderText = "Status";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void AddActivity_Button_Click(object sender, EventArgs e)
        {
            ActivityEditor activityEditor = new ActivityEditor(request);
            activityEditor.ShowDialog();
            Activity activity = new Activity();
            activity.id_request = request.id_request;
            try
            {
                var result = ManagerService.GetActivities(activity);
                Activities_DataGridView.Columns.Clear();
                Activities_DataGridView.DataSource = result.ToList();

                Activities_DataGridView.Columns[0].Visible = false;
                Activities_DataGridView.Columns[3].Visible = false;
                Activities_DataGridView.Columns[7].Visible = false;
                Activities_DataGridView.Columns[8].Visible = false;
                Activities_DataGridView.Columns[9].Visible = false;

                Activities_DataGridView.Columns[1].HeaderText = "Seq";
                Activities_DataGridView.Columns[2].HeaderText = "Description";
                Activities_DataGridView.Columns[4].HeaderText = "Date Request";
                Activities_DataGridView.Columns[5].HeaderText = "Date Finish";
                Activities_DataGridView.Columns[6].HeaderText = "Status";
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(request==null)
                {
                    request = new Request();
                    request.description = Description_TextBox.Text;
                    request.id_object = obj.id_object;
                    request.status = "PROG";
                    request.id_activity = 0;
                    request.result = "";
                    request.date_request = System.DateTime.Now;
                    ManagerService.NewRequest(request);
                    AddActivity_Button.Enabled = true;
                    DeleteActivity_Button.Enabled = true;
                }else
                {
                    request.description = Description_TextBox.Text;
                    ManagerService.UpdateRequest(request);
                    this.Close();
                    this.Dispose();
                }
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void MoveDown_Button_Click(object sender, EventArgs e)
        {

        }

        private void MoveUp_Button_Click(object sender, EventArgs e)
        {

        }

        private void DeleteActivity_Button_Click(object sender, EventArgs e)
        {
            if ((Activity)Activities_DataGridView.CurrentRow.DataBoundItem == null)
            {
                Alert.DisplayError("No item selected!");
                return;
            }
            try
            {
                ManagerService.DeleteActivity((Activity)Activities_DataGridView.CurrentRow.DataBoundItem);
                int index = Activities_DataGridView.CurrentRow.Index;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[Activities_DataGridView.DataSource];
                currencyManager.SuspendBinding();
                Activities_DataGridView.Rows[index].Visible = false;
                currencyManager.ResumeBinding();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }
    }
}
