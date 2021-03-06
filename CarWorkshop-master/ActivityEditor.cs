﻿using System;
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
    public partial class ActivityEditor : Form
    {
        private Activity activity;
        private Request request;
        private List<Personel> workers;//list of workers
        private List<Act_dict> types;//list of types
        public ActivityEditor(Activity activity)//edition mode
        {
            InitializeComponent();

            Worker_ComboBox.Items.AddRange(GetWorkers());
            this.activity = activity;
            Description_TextBox.Text = activity.description;
            GetTypes();
        }

        public ActivityEditor(Request request)//new Activity mode
        {
            InitializeComponent();

            Worker_ComboBox.Items.AddRange(GetWorkers());
            this.request = request;
            GetTypes();
        }

        private string [] GetWorkers()
        {
            try
            {
                var result = AdminService.GetPersonelActive(new Personel()).ToList();
                workers = result.ToList();
                string [] workersArray = (from el in result select el.first_name).ToArray();
                for(int i = 0; i < workersArray.Length; i++)
                {
                    workersArray[i] += (" " + workers[i].last_name);
                }
                return workersArray;
            } catch (ServiceException e)
            {
                Alert.DisplayError(e.Message);
                this.Close();
                this.Dispose();
                return null;
            }
        }

        private void TypeAdding_Button_Click(object sender, EventArgs e)
        {
            NewTypeAdding newTypeAdding = new NewTypeAdding(false);
            newTypeAdding.ShowDialog();
            GetTypes();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(Type_ComboBox.Text)||String.IsNullOrWhiteSpace(Worker_ComboBox.Text))
            {
                Alert.DisplayError("Invalid input!");
                return;
            }
            try
            {
                if(activity==null)
                {
                    activity = new Activity();
                }
                activity.act_type = (from el in types where Type_ComboBox.Text == el.act_name select el.act_type).SingleOrDefault();//find type in ist of types by selected name
                activity.id_personel = workers[Worker_ComboBox.SelectedIndex].id_personel;
                activity.description = Description_TextBox.Text;
                if(request==null)
                {
                    ManagerService.UpdateActivity(activity);
                }else
                {
                    activity.id_request = request.id_request;
                    activity.status = "In progress";
                    activity.id_personel = request.id_personel;
                    activity.date_request = System.DateTime.Now;
                    ManagerService.NewActivity(activity);
                }
                this.Close();
                this.Dispose();
            }
            catch (ServiceException exc)
            {
                Alert.DisplayError(exc.Message);
            }
        }

        private void ActivityEditor_Load(object sender, EventArgs e)
        {

        }
        //get types and fill ComboBox
        private void GetTypes()
        {
            try
            {
                types = ManagerService.GetActTypes().ToList();
                Type_ComboBox.Items.Clear();
                Type_ComboBox.Items.AddRange((from el in types select el.act_name).ToArray());
            }catch (ServiceException e)
            {
                Alert.DisplayError(e.Message);
            }
        }
    }
}
