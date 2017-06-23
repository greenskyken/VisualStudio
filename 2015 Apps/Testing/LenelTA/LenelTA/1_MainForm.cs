using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenelTA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AdvanceEndDate();

            FillAreaCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLoadRecords.Enabled = false;

            LoadData();
        }

        private void AdvanceEndDate()
        {
            dateEndDate.Value = dateStartDate.Value.AddDays(1);

            dateEndDate.MaxDate = dateStartDate.Value.AddMonths(1);
        }

        private void FillAreaCombo()
        {

        }

        private void loadParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Loading Lenel Records";
            label2.Refresh();

            btnLoadRecords.Enabled = false;

            LoadData();
        }

        void LoadData()
        {
            LoadRecords LoadAllRecords = new LoadRecords();

            label2.Text = "Loading Lenel Records - 1/3";
            label2.Refresh();
            LoadAllRecords.LoadAreaRecords();

            label2.Text = "Loading Lenel Records - 2/3";
            label2.Refresh();
            LoadAllRecords.LoadSnapRecords();

            label2.Text = "Loading Lenel Records - 3/3";
            label2.Refresh();
            LoadAllRecords.LoadVictorRecords();

            label2.Text = "Loading Data - Complete";
            label2.Refresh();
        }

        private void rdoOneDaySelect_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoOneDaySelect.Checked)
            {
                label7.Visible = false;
                dateEndDate.Visible = false;
            }
        }

        private void rdoOneWeekSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneWeekSelect.Checked)
            {
                label7.Visible = false;
                dateEndDate.Visible = false;
            }
        }

        private void rdoOneMonthSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneMonthSelect.Checked)
            {
                label7.Visible = false;
                dateEndDate.Visible = false;
            }
        }

        private void rdoDateSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDateSelect.Checked)
            {
                label7.Visible = true;
                dateEndDate.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
        }

        private void cmboLocationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmboLocationSelect.Text)
            {
                case "Snap Lake":
                    {
                        //
                        break;
                    }
                case "Victor Mine":
                    {
                        //
                        break;
                    }
                case "Gahcho Kue":
                    {
                        //
                        break;
                    }
            }
        }
    }
}
