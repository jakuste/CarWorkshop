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
        }

        public RequestEditor(Request request)
        {
            InitializeComponent();
            this.request = request;
            //RegistrationNumber_TextBox.Text = request.Object.registration_number;
            BodyType_TextBox.Text = request.Object.body_type;
            Name_TextBox.Text = request.Object.name;
            Engine_TextBox.Text = request.Object.engine;
            Manufacturer_TextBox.Text = request.Object.manufacturer;
            Year_TextBox.Text = request.Object.year.ToString();
            Model_TextBox.Text = request.Object.model;
            Other_TextBox.Text = request.Object.other;
            Description_TextBox.Text = request.description;
        }

        private void AddActivity_Button_Click(object sender, EventArgs e)
        {
            ActivityEditor activityEditor = new ActivityEditor();
            activityEditor.ShowDialog();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
