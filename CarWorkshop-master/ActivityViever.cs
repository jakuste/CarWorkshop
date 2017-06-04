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
    public partial class ActivityViever : Form
    {
        public ActivityViever()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            // + zmienia status na "cancled"
        }

        private void StartWork_Button_Click(object sender, EventArgs e)
        {
            // + zmienia status na "in progress"
        }

        private void Finish_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            // + zmienia status na "finished"
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
