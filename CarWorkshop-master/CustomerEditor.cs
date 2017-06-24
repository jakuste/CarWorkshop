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
            Name_TextBox.Text = client.first_name;
            Surname_TextBox.Text = client.last_name;
            if(client.last_name==null)
            {
                Company_CheckBox.Checked = true;
                Name_TextBox.Text = client.name;
            }
            Street_TextBox.Text = client.street;
            City_TextBox.Text = client.city;
            Country_TextBox.Text = client.country;
            Number_TextBox.Text = client.home;
            Flat_TextBox.Text = client.flat;
            PESEL_TextBox.Text = client.PESEL_NIP;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(PESEL_TextBox.Text))
            {
                Alert.DisplayError("Invalid input values!");
                return;
            }


            try
            { 
                if (client == null)
                {
                    FillClient();
                    ManagerService.NewClient(client);
                }
                else
                {
                    FillClient();
                    ManagerService.UpdateClient(client);
                }
                this.Close();
                this.Dispose();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FillClient()
        {
            if(client==null)
            {
                client = new Client();
            }
            if(Company_CheckBox.Checked)
            {
                client.name = Name_TextBox.Text;
            }
            else
            {
                client.first_name = Name_TextBox.Text;
                client.last_name = Surname_TextBox.Text;
            }
            client.street = Street_TextBox.Text;
            client.city = City_TextBox.Text;
            client.home = Number_TextBox.Text;
            client.flat = Flat_TextBox.Text;
            client.PESEL_NIP = PESEL_TextBox.Text;
            client.country = Country_TextBox.Text;
        }
    }
}
