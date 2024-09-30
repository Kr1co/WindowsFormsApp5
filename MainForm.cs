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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static List<int> JuriList;
        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void juri_Click(object sender, EventArgs e)
        {
            JuriList = new List<int>();
            JuriList = JsonSerializer.Deserialize<List<int>>
                (activityDataGridView.CurrentRow.Cells[6].Value.ToString());
            ShowJuriForm showJuri = new ShowJuriForm();
            showJuri.ShowDialog();
        }

        private void activity_Click(object sender, EventArgs e)
        {
            AddActivityForm activity = new AddActivityForm();
            activity.ShowDialog();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }
    }
}
