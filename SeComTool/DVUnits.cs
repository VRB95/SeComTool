using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeComTool
{
    public partial class DVUnits : Form
    {
        public DVUnits()
        {
            InitializeComponent();
            BindDataCSV("Unit.csv");
        }

        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string[] headerLabels = new string[3];
                int deviceVariableCounter = 1;
                for (int row = 0; row < lines.Length; row++)
                {
                    string[] dataWords = lines[row].Split(',');
                    DataRow dataRow = dt.NewRow();

                    switch (dataWords[0])
                    {
                        case "#H1#":
                            int counter = 0;
                            for (int h = 1; h < dataWords.Length; h++)
                            {
                                dt.Columns.Add(new DataColumn(dataWords[h]));
                                headerLabels[counter] = dataWords[h];
                                counter++;
                            }
                            // treate serparatly the HEX
                            dt.Columns.Add(new DataColumn("HexCode"));
                            headerLabels[counter++] = "HexCode";
                            break;
                        case "#H2#":
                            int columnIndex = 0;
                            for (int val = 1; val < dataWords.Length; val++)
                            {
                                dataWords[1] = deviceVariableCounter.ToString() + ". " + dataWords[1];
                                dataRow[columnIndex] = dataWords[val];
                                columnIndex++;
                             
                            }
                            dt.Rows.Add(dataRow);
                            deviceVariableCounter++;
                            break;
                        case "":
                            break;
                        default:
                            columnIndex = 0;
                            for (int val = 0; val < 3; val++)
                            {
                                if (val == 2)
                                {
                                    int dec = int.Parse(dataWords[0]);
                                    string hex = dec.ToString("x");
                                    dataRow[2] = hex;
                                    columnIndex++;
                                }
                                else
                                {
                                    dataRow[val] = dataWords[columnIndex];
                                    columnIndex++;
                                }
                            }
                            dt.Rows.Add(dataRow);

                            break;
                    }
                    
                }
                if (dt.Rows.Count > 0)
                {
                    unitsDataGridView.DataSource = dt;
                    

                }
            }
        }


        private void unitsSearchbtn_Click(object sender, EventArgs e)
        {
            string searchValue = unitsSearchtxt.Text;
            unitsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in unitsDataGridView.Rows)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int rowIndex = row.Index;
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            unitsDataGridView.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            unitsDataGridView.Focus();
                            unitsDataGridView.CurrentCell = unitsDataGridView.Rows[rowIndex].Cells[i];
                            break;
                        }
                        else
                        {
                            unitsDataGridView.Rows[rowIndex].Selected = false;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + unitsDataGridView.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
