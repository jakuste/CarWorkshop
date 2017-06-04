using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class ActivityEditor : Form
    {
        public ActivityEditor()
        {
            InitializeComponent();
        }

        private void TypeAdding_Button_Click(object sender, EventArgs e)
        {
            NewTypeAdding newTypeAdding = new NewTypeAdding();
            newTypeAdding.ShowDialog();
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

        private void ActivityEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
