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
    public partial class RequestEditor : Form
    {
        public RequestEditor()
        {
            InitializeComponent();
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
