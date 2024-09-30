using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using WindowsFormsApp5.DCom;

namespace WindowsFormsApp5
{
    public partial class AddActivityForm : Form
    {
        public AddActivityForm()
        {
            InitializeComponent();
        }
        private List<int> Id_Juri = new List<int>();
        private void AddActivityForm_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            userBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            userbindingSource2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }

        private void AddActivity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните поле Название!");
                return;
            }
            try
            {
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("В поле день должно стоять целочисленное значение!");
            }
            if (Id_Juri.Count <= 0)
            {
                MessageBox.Show("Добавте хотябы одного члена жюри");
                return;
            }
            Activity activity = new Activity();
            activity.Title = textBox1.Text;
            activity.EventPlanID = (int)EventPlancomboBox.SelectedValue;
            activity.Day = Convert.ToInt32(textBox2.Text);
            activity.StartedAt = dateTimePicker1.Value.TimeOfDay;
            activity.ModeratorID = (int)ModeratorcomboBox.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(Id_Juri);
            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }

        private void AddJuri_Click(object sender, EventArgs e)
        {
            int id = (int)JuricomboBox.SelectedValue;
            if (!Id_Juri.Contains(id))
            {
                Id_Juri.Add(id);
                MessageBox.Show($"Пользователь с ID - {JuricomboBox.SelectedValue} добавлен!");
                return;
            }
            MessageBox.Show("Нельзя добавить одного и того же Жюри");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
