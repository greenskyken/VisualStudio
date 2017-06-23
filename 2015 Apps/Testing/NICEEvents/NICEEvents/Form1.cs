using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NICEEvents
{
    public partial class NICE_Events : Form
    {
        public NICE_Events()
        {
            InitializeComponent();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void snapLakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Snap_Lake Connection String Into Dataset
            lblLocation.Text = "Snap Lake";
        }

        private void victorMineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Victor Connection String Into Dataset
            lblLocation.Text = "Victor Mine";
        }

        private void gahchoKueProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Gahcho_Kue Connection String Into Dataset
            lblLocation.Text = "Gahcho Kue";
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm InfoForm = new InfoForm();

            InfoForm.Show();
        }

        /*
        private void ExportToExcel()
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = lblLocation.Text;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < DGV1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Complete, Thank You");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        */
        private void ExportToExcel()
        {
            Disable_Menus_Buttons();
            
            // Don't save if no data is returned
            if (DGV1.Rows.Count == 0)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < DGV1.Columns.Count; i++)
            {
                columnsHeader += DGV1.Columns[i].Name + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in DGV1.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                }
            }
            // Confirm to the user it has been completed.
            MessageBox.Show("CSV file saved.");

            Enable_Menus_Buttons();
        }


        private void btnGO_Click(object sender, EventArgs e)
        {
            //Connect to Database and retrieve view
            string choice;

            switch (lblLocation.Text)
            {
                case "Victor Mine":
                    choice = "Data Source=10.25.154.105;Database=EVENTS;Timeout=10;Initial Catalog=EVENTS;Persist Security Info=True;User ID=vision;Password=vision";
                    DBConnectLoad(choice);
                    break;

                case "Snap Lake":
                    choice = "Data Source=10.25.240.45;Database=EVENTS;Timeout=10;Initial Catalog=EVENTS;Persist Security Info=True;User ID=vision;Password=vision";
                    DBConnectLoad(choice);
                    break;

                case "Gahcho Kue":
                    choice = "Data Source=10.25.240.45;Database=EVENTS;Timeout=10;Initial Catalog=EVENTS;Persist Security Info=True;User ID=vision;Password=vision";
                    DBConnectLoad(choice);
                    break;
            }
        }

        private void DBConnectLoad(string choice)
        {
            //Connect to database
            string nudDays = Convert.ToString(nudResultDays.Value);
            SqlConnection sqlcon = new SqlConnection();
            

            string constring = choice;
            string conquery = "SELECT [EventTypeName] as Event,[SensorName] as Camera,[OpenedDate] as 'Start Time' ,[ClosedDate] as 'End Time' FROM [EVENTS].[dbo].[EVENT_INFO] WHERE OpenedDate > DATEADD(day, -" + nudDays + ", GETDATE()) AND EventTypeName = 'Motion Detection' ORDER BY OpenedDate";

            //Create Adapter and set timeout to never
            SqlDataAdapter conadapter = new SqlDataAdapter(conquery, choice);
            conadapter.SelectCommand.CommandTimeout = 0;

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(conadapter);

            Disable_Menus_Buttons();

            //fill adapter
            DataSet ds = new DataSet();
            conadapter.Fill(ds);

            //fill DataGridView
            DGV1.DataSource = ds.Tables[0];

            lblEventsCount.Text = Convert.ToString(DGV1.RowCount);
            lblPending.Text = "          ";

            Enable_Menus_Buttons();
        }

        private void Disable_Menus_Buttons()
        {
            //disable all controls
            btnGO.Enabled = false;
            menuStrip1.Enabled = false;
            nudResultDays.Enabled = false;
        }

        private void Enable_Menus_Buttons()
        {
            //disable all controls
            btnGO.Enabled = true;
            menuStrip1.Enabled = true;
            nudResultDays.Enabled = true;
        }

    }
}
