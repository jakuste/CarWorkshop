using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    public partial class ObjectEditor : Form
    {
        public ObjectEditor()
        {
            InitializeComponent();
        }

        public ObjectEditor(string DataOfObject)
        {
            InitializeComponent();

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
            }
        }

        private void AddType_Button_Click(object sender, EventArgs e)
        {
            NewTypeAdding newTypeAdding = new NewTypeAdding();
            newTypeAdding.ShowDialog();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
