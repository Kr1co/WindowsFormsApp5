using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.DCom;

namespace WindowsFormsApp5
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void Fill(User user, int number)
        {
            firstnameTextBox.Text =  "Жюри - " + number.ToString();
            userBindingSource.DataSource = user;
        }
    }
}
