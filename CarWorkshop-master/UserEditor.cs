using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace CarWorkshop
{
    public partial class UserEditor : Form
    {
        private Personel user;
        public UserEditor()
        {
            InitializeComponent();
            user = null;
            this.Role_ComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Worker" });
        }

        public UserEditor(Personel user)
        {
            InitializeComponent();
            this.Role_ComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Worker" });
            Name_TextBox.Text = user.first_name;
            Surname_TextBox.Text = user.last_name;
            Username_TextBox.Text = user.username;
            Role_ComboBox.Text = user.role;
            Date_Retire.Value = (System.DateTime)user.date_retire;
            this.user = user;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if((Name_TextBox.Text==null)||(Surname_TextBox.Text==null)||(Username_TextBox.Text==null)||(Password_TextBox.Text==null))
            {
                Alert.DisplayError("Invalid input values!");
                return;
            }
            try
            {
                Personel personel = new Personel();
                personel.date_retire = Date_Retire.Value;
                personel.first_name = Name_TextBox.Text;
                personel.last_name = Surname_TextBox.Text;
                personel.username = Username_TextBox.Text;
                personel.password = Password_TextBox.Text;
                personel.role = Role_ComboBox.Text;
                if (user == null)
                {
                    AdminService.NewPersonel(personel);

                }
                else
                {
                    AdminService.UpdatePersonel(personel);
                }
                this.Close();
                this.Dispose();
            }catch(ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
