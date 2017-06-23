using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Server
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _2_add_form addform = new _2_add_form();
            addform.Show();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            _3_modify_form modform = new _3_modify_form();
            modform.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _4_delete_form delform = new _4_delete_form();
            delform.Show();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            _5_reports_form repform = new _5_reports_form();
            repform.Show();
        }
    }
}
