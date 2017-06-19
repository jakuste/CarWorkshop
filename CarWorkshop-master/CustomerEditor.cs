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
    public partial class CustomerEditor : Form
    {
        private Client client = null;
        public CustomerEditor()
        {
            InitializeComponent();
        }

        public CustomerEditor(Client client)
        {
            InitializeComponent();
            this.client = client;
            Name_TextBox.Text = client.name;
            Surname_TextBox.Text = client.last_name;
            if(client.last_name==null)
            {
                Company_CheckBox.Checked = true;
            }
            Street_TextBox.Text = client.street;
            City_TextBox.Text = client.city;

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            
            if(Company_CheckBox.Checked)
            {
                if ((Name_TextBox.Text == null) || (Street_TextBox.Text == null) || (City_TextBox.Text == null) || (Country_TextBox.Text == null) || (Number_TextBox.Text == null))
                {
                    Alert.DisplayError("Invalid input values!");
                    return;
                }
            }
            else
            {
                if ((Name_TextBox.Text == null) || (Surname_TextBox.Text == null) || (Street_TextBox.Text == null) || (City_TextBox.Text == null) || (Country_TextBox.Text == null) || (Number_TextBox.Text == null))
                {
                    Alert.DisplayError("Invalid input values!");
                    return;
                }
            }
            try
            {
                Client client = new Client();
                client.name = Name_TextBox.Text;
                client.last_name = Name_TextBox.Text;
                client.street = Street_TextBox.Text;
                client.city = City_TextBox.Text;
                client.flat = Number_TextBox.Text;
                if (client == null)
                {
                    ManagerService.NewClient(client);

                }
                else
                {
                    ManagerService.UpdateClient(client);
                }
                this.Close();
                this.Dispose();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }
    }
}
