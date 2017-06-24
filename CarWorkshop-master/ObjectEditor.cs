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
    public partial class ObjectEditor : Form
    {
        private List<Object_type> types;
        private DataLayer.Object obj;
        private Client client; 

        public ObjectEditor(DataLayer.Object obj)
        {
            InitializeComponent();
            this.obj = obj;
            GetTypes();

            Type_ComboBox.Text = (from el in types where el.code_type == obj.code_type select el.name_type).SingleOrDefault();
            Name_TextBox.Text = obj.name;
            RegistrationNumber_TextBox.Text = obj.registration_number;
            Manufacturer_TextBox.Text = obj.manufacturer;
            Model_TextBox.Text = obj.model;
            BodyType_TextBox.Text = obj.body_type;
            Engine_TextBox.Text = obj.engine;
            Year_textBox.Text = obj.year.ToString();
            Other_TextBox.Text = obj.other;
        }

        public ObjectEditor(Client client)
        {
            InitializeComponent();
            this.client = client;
            GetTypes();
            /*
            if (DataOfObject == "seeDatails")
            {
                Cancel_Button.Visible = false;
                Cancel_Button.Enabled = false;
                Save_Button.Text = "OK";
                AddType_Button.Enabled = false;

                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Enabled = false;
                    }
                    else if (x is ComboBox)
                    {
                        ((ComboBox)x).Enabled = false;
                    }
                }
            }*/

        }

        private void AddType_Button_Click(object sender, EventArgs e)
        {
            NewTypeAdding newTypeAdding = new NewTypeAdding(true);
            newTypeAdding.ShowDialog();
            GetTypes();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(RegistrationNumber_TextBox.Text)|| String.IsNullOrWhiteSpace(Type_ComboBox.Text))
            {
                Alert.DisplayError("Registration number box must be filled!");
                return;
            }
            try
            {
                if (obj == null)
                {
                    obj = new DataLayer.Object();
                }
                obj.code_type = (from el in types where el.name_type == Type_ComboBox.Text select el.code_type).SingleOrDefault();
                obj.name = Name_TextBox.Text;
                obj.registration_number = RegistrationNumber_TextBox.Text;
                obj.manufacturer = Manufacturer_TextBox.Text;
                obj.model = Model_TextBox.Text;
                obj.body_type = BodyType_TextBox.Text;
                obj.engine = Engine_TextBox.Text;
                obj.year = Int32.Parse(Year_textBox.Text);
                obj.other = Other_TextBox.Text;

                if (client == null)
                {
                    ManagerService.UpdateObject(obj);
                }
                else
                {
                    obj.id_client = client.id_client;
                    ManagerService.NewObject(obj);
                }
                this.Close();
                this.Dispose();
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

        private void GetTypes()
        {
            try
            {
                types = ManagerService.GetObjectTypes().ToList();
                Type_ComboBox.Items.Clear();
                Type_ComboBox.Items.AddRange((from el in types select el.name_type).ToArray());
            }
            catch (ServiceException e)
            {
                Alert.DisplayError(e.Message);
            }
        }

        private void FillObject(DataLayer.Object obj)
        {
        }
    }
}
