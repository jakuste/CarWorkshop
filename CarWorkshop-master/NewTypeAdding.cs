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
    // okno dodawania nowego typu obiektu oraz nowego typu activity
    public partial class NewTypeAdding : Form
    {
        bool mode;
        public NewTypeAdding(bool mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(Type_TextBox.Text)||String.IsNullOrWhiteSpace(CodeOfType_TextBox.Text))
            {
                Alert.DisplayError("Invalid input!");
                return;
            }
            try
            {
                if(!mode)
                {
                    Act_dict type = new Act_dict();
                    type.act_name = Type_TextBox.Text;
                    type.act_type = CodeOfType_TextBox.Text;
                    ManagerService.NewActType(type);
                    this.Close();
                    this.Dispose();
                }else
                {
                    Object_type type = new Object_type();
                    type.name_type = Type_TextBox.Text;
                    type.code_type = CodeOfType_TextBox.Text;
                    ManagerService.NewObjectType(type);
                    this.Close();
                    this.Dispose();
                }
            } catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
            
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
