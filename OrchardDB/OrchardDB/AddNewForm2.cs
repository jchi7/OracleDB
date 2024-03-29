﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrchardDB
{
    public partial class AddNewForm2 : Form
    {

        public AddNewForm2()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            int b = 0;
            List<string> errList = new List<string>();
            using (ODBEntities contextOdbEntities = new ODBEntities())
            {
                if (AddDataGrid.Rows[0].Cells[0].ToString().Trim() != "")
                {
                    for (int i = 0; i < AddDataGrid.RowCount - 1; i++)
                    {
                        string farmname = AddDataGrid.Rows[0].Cells[0].ToString().Trim();
                        if (contextOdbEntities.JCMA_FARM.Any(n => n.FARM_NAME != farmname))
                        {
                            string farmName = "";
                            string location = "";
                            string ownerName = "";
                            List<string> insertedList = new List<string>();
                            for (int j = 0; j < AddDataGrid.ColumnCount; j++)
                            {
                                switch (j)
                                {
                                    case 0:
                                        farmName = AddDataGrid.Rows[i].Cells[j].Value.ToString().Trim();
                                        break;
                                    case 1:
                                        try
                                        {
                                            location = AddDataGrid.Rows[i].Cells[j].Value.ToString().Trim();
                                        }
                                        catch
                                        {
                                            location = "";
                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            ownerName = AddDataGrid.Rows[i].Cells[j].Value.ToString().Trim();
                                        }
                                        catch (Exception)
                                        {
                                            ownerName = "";
                                        }
                                        break;
                                    default:
                                        MessageBox.Show("ERROR");
                                        break;
                                }
                            }
                            if (farmName == string.Empty)
                                continue;
                            try
                            {
                                b -= contextOdbEntities.INSERT_FARM(farmName, location, ownerName);
                            }
                            catch
                            {
                                MessageBox.Show("Error in inserting");
                            }
                        }
                        else
                        {
                            errList.Add(farmname + " already exist in the database.");
                        }
                    }
                    MessageBox.Show(string.Format("{0} number of records has been saved.", b));
                }
            }
            if (errList.Count != 0)
            {
                string err = string.Empty;
                foreach (string line in errList)
                {
                    err += line + "\n";
                }
                MessageBox.Show(err);
            }
            Close();
        }

        private void Check_PK_Farm(string farmName)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
