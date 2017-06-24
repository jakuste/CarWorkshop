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
    public partial class ActivityViever : Form
    {
        private Activity activity;

        public ActivityViever(Activity activity)
        {
            InitializeComponent();
            this.activity = activity;
            Request request = activity.Request;
            RegistrationNumber_TextBox.Text = request.Object.registration_number;
            BodyType_TextBox.Text = request.Object.body_type;
            Name_TextBox.Text = request.Object.name;
            Engine_TextBox.Text = request.Object.engine;
            Manufacturer_TextBox.Text = request.Object.manufacturer;
            Year_TextBox.Text = request.Object.year.ToString();
            Model_TextBox.Text = request.Object.model;
            Other_TextBox.Text = request.Object.other;
            RequestDescription_TextBox.Text = request.description;
            ActivityDescription_TextBox.Text = activity.description;
            Date_TextBox.Text = activity.date_fin_cancel.ToString();
            Result_TextBox.Text = activity.result;
            Status_TextBox.Text = activity.status;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            UpdateStatus("Canceled");
        }

        private void StartWork_Button_Click(object sender, EventArgs e)
        {
            UpdateStatus("In progress");
        }

        private void Finish_Button_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            UpdateStatus("Finished");
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void UpdateStatus(string status)
        {
            activity.status = status;
            if((status=="Finished") || (status=="Canceled"))
            {
                activity.date_fin_cancel = System.DateTime.Now;
            }
            try
            {
                ManagerService.UpdateActivity(activity);
                Status_TextBox.Text = status;
            }
            catch(ServiceException e)
            {
                Alert.DisplayError(e.Message);
            }
        }
    }
}
