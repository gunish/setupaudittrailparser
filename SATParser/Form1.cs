using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SATParser
{
    public partial class FormSAT : Form
    {
        public FormSAT()
        {
            InitializeComponent();
        }

        private void LogMessage(string message)
        {
            this.textBoxLog.Text = this.textBoxLog.Text + Environment.NewLine;
            this.textBoxLog.Text = this.textBoxLog.Text + message;
        }


        private DataTable localSAT;
        private DataTable updatedSAT;

        private void buttonSATLoad_Click(object sender, EventArgs e)
        {
            DialogResult drSource = openFileDialogSAT.ShowDialog();
            if (drSource == DialogResult.OK)
            {

                textBoxSAT.Text = openFileDialogSAT.FileName;
                localSAT = GetDataTable(textBoxSAT.Text);
                dataGridViewSAT.DataSource = localSAT;

                localSAT = FindNewLineCharacters(localSAT);
                LogMessage("Setup Audit Trail Loaded");
                LogMessage("Setup Audit Train has " + localSAT.Rows.Count.ToString() + " Rows");
                SetFilters();
            }
           
        }

        private void SetFilters()
        {
            DataRow[] localRows = localSAT.Select(null, "Date", DataViewRowState.CurrentRows);
            dateTimePicker1.MinDate = Convert.ToDateTime(localRows[0]["Date"].ToString());
            dateTimePicker1.MaxDate = Convert.ToDateTime(localRows[localRows.Length - 1]["Date"].ToString());
            dateTimePicker2.MinDate = Convert.ToDateTime(localRows[0]["Date"].ToString());
            dateTimePicker2.MaxDate = Convert.ToDateTime(localRows[localRows.Length - 1]["Date"].ToString());

            dateTimePicker1.Value = Convert.ToDateTime(localRows[0]["Date"].ToString());
            dateTimePicker2.Value = Convert.ToDateTime(localRows[localRows.Length - 1]["Date"].ToString());

            DataTable tempTable = localSAT.DefaultView.ToTable(true, "User");

            foreach (DataRow itemRow in tempTable.Rows)
            {
                checkedListBox1.Items.Add(itemRow[0].ToString());
            }

            LogMessage("The Setup Audit Trail Has Log Start Date : " + localRows[0]["Date"].ToString() + " and End Date :" + localRows[localRows.Length - 1]["Date"].ToString());
            LogMessage("The Setup Audit Trail has Events with :" + tempTable.Rows.Count.ToString() + " users");
        }

        public void WriteToCsvFile(DataTable dataTable, string filePath)
        {
            StringBuilder fileContent = new StringBuilder();

            foreach (var col in dataTable.Columns)
            {
                fileContent.Append("\"" + col.ToString() + "\"" + ",");
            }

            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);



            foreach (DataRow dr in dataTable.Rows)
            {

                foreach (var column in dr.ItemArray)
                {
                    fileContent.Append("\"" + column.ToString() + "\",");
                }

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(filePath, fileContent.ToString(), Encoding.UTF8);

        }

        private DataTable FindNewLineCharacters(DataTable localTable)
        {

            int counterComa = 0;
            foreach (DataRow itemRow in localTable.Rows)
            {
                for (int i = 0; i < localTable.Columns.Count; i++)
                {

                    if (itemRow[i].ToString().Contains("\""))
                    {
                        itemRow[i] = itemRow[i].ToString().Replace("\"", "");
                        itemRow[i] = itemRow[i].ToString().Replace("'", "");
                        itemRow[i] = itemRow[i].ToString().Replace("from", "brom");
                        //itemRow[i] = removeFaaf(itemRow[i].ToString());
                        counterComa++;
                    }

                }
            }

            return localTable;
        }

        private returnValues removeFaaf(string p, string q)
        {
            string o = "";

            if (p.Contains("picklist") && (q.Contains("Customize") || q.Contains("Custom")))
            {
                if (p.StartsWith("Added value"))
                {
                    p = p.Substring(p.IndexOf("to") + "to".Length, (p.IndexOf("picklist") - (p.IndexOf("to") + "to".Length)));
                    p = p.Trim();
                }
                else if (p.StartsWith("Changed"))
                {
                    p = p.Replace("Changed", "");
                    p = p.Substring(0, p.Length - (p.Length - p.IndexOf("picklist")));
                    p = p.Trim();
                }
                else if (p.StartsWith("Reordered"))
                {
                    p = p.Replace("Reordered", "");
                    p = p.Replace("picklist", "");
                    p = p.Trim();
                }
                else if (p.StartsWith("Deleted value"))
                {
                    p = p.Substring(p.IndexOf("from"), (p.IndexOf("picklist") - p.IndexOf("from")));
                    p = p.Trim();
                }


                o = "field on" + q.Replace("Customize", "");
            }

            if (p.Contains("field name"))
            {
                p = p.Substring(p.IndexOf(" to "), p.Length - p.IndexOf(" to "));
                o = "field on" + q.Replace("Customize", "");
            }

            if (p.Contains("workflow rule "))
            {
                o = p.Substring(p.IndexOf("for Object:"), p.Length - (p.IndexOf("for Object:")));
                
                p = p.Replace("workflow rule ", "");
                p = p.Substring(0, p.IndexOf("for Object:"));
                p = p.Trim() + ".workflow";

            }

            if (p.Contains("Email Alert"))
            {
                o = "Email Alert " + p.Substring(p.IndexOf("for Object:"), p.Length - (p.IndexOf("for Object:")));
                
                p = p.Replace("Email Alert ", "");
                p = p.Substring(0, p.IndexOf("for Object:"));
                //p = p.Trim() + ".workflow";

            }


            p = p.Replace("brom 0 to 1", "");
            p = p.Replace("brom 1 to 0", "");
            p = p.Replace("from on to off","");
            p = p.Replace("from off to on","");

            if (p.Contains("Trigger code"))
            {
                int startIndex = p.IndexOf(":") + 2;
                int lengthOfSubstring = (p.Length - startIndex);
                p = p.Substring(startIndex, lengthOfSubstring);
                p = p.TrimEnd() + ".trigger";
            }
            //p = p.Replace("Changed Person Trigger code: ", "");
            p = p.Replace("Changed active flag for", "");
            p = p.Replace("Completed sharing rule recalculation:", "");
            p = p.Replace("Initiated sharing rule recalculation:", "");
            p = p.Replace("Created", "");
            p = p.Replace("Deleted", "");
            p = p.Replace("Changed", "");
            p = p.Replace("Completed", "");
            p = p.Replace("Initiated", "");
            p = p.Replace(" Apex Class code", ".class");
            
            if(p.Contains("Page")) {
                p = p.Replace("Page ", "");
                p = p.TrimEnd() + ".page";
            }


            if (p.Contains("brom"))
            {
                int startIndex = p.IndexOf("brom");
                int subStringLenght = p.Length - (p.Length - startIndex);
                p = p.Substring(0, subStringLenght);
            }

            if (p.Contains("validation") && q.ToLower() == "validation rules")
            {
                o = p.Substring(0,p.Length - (p.Length - p.IndexOf("validation")));
                p = p.Substring(p.IndexOf("validation") + ("validation").Length, p.Length - (p.IndexOf("validation") + "validation".Length));
            }


            if (p.Contains("Component") && q.ToLower().Trim() == "component")
            {
                p = p.Replace("Component", "");
                p = p.Trim() + ".component";
            }

            if (p.Contains("page layout") && (q.Contains("Customize") || q.Contains("Custom")))
            {
                o = p.Substring(0, p.Length - (p.Length - p.IndexOf("page layout")));
                p = o.TrimEnd() + "-" + (p.Substring(p.IndexOf("page layout") + ("page layout").Length, p.Length - (p.IndexOf("page layout") + "page layout".Length))).TrimStart();
                p = p.TrimEnd() + ".layout";
            }

            if (p.Contains("custom object tab: "))
            {
                p = p.Replace("custom object tab: ","");
                p = p.TrimEnd() + ".tab";
            }

            returnValues objreturnValues = new returnValues();
            
            objreturnValues.p = p;
            objreturnValues.q = q;
            objreturnValues.o = o; 
            
            return objreturnValues;
        }

        private void ProcessSATRecords()
        {
            updatedSAT = localSAT.Clone();
            updatedSAT.Columns.Add(new DataColumn("Object"));
            
            foreach (DataRow sourceRow in localSAT.Rows)
            {
                Boolean flagDate = false;
                Boolean flagUser = false;
                flagDate = CheckDate(sourceRow["Date"].ToString());
                flagUser = CheckUser(sourceRow["User"].ToString());

                if (flagDate && flagUser)
                {

                    returnValues objReturnValues = removeFaaf(sourceRow["Action"].ToString().Replace("'", ""), sourceRow["Section"].ToString());

                    string sourceRowAction = objReturnValues.p;
                    string objectName = objReturnValues.o;

                    Boolean flag = false;

                    DataRow[] SATRows = updatedSAT.Select("Action = '" + sourceRowAction + "'");

                    if (SATRows.Length == 0)
                        flag = true;

                    if (updatedSAT.Rows.Count == 0)
                        flag = true;

                    if (flag)
                    {
                        DataRow newRow = updatedSAT.NewRow();
                        newRow["Date"] = sourceRow["Date"];
                        newRow["User"] = sourceRow["User"];
                        newRow["Action"] = sourceRowAction;
                        newRow["Section"] = sourceRow["Section"];
                        newRow["Delegate User"] = sourceRow["Delegate User"];
                        newRow["Object"] = objectName;
                        if (newRow["Section"].ToString() != "Manage Users" && newRow["Section"].ToString() != "Data Management")
                        {
                            updatedSAT.Rows.Add(newRow);
                        }

                    }
                }
            }

            LogMessage("Finished Processing Unique Rows, Rows Reduced to : " + updatedSAT.Rows.Count.ToString() + " rows");
            dataGridViewSAT.DataSource = updatedSAT; 
        }

        private bool CheckUser(string p)
        {
            Boolean returnValue = false;    
            if (!checkBox2.Checked)
            {
                foreach (var item in checkedListBox1.SelectedItems)
                {
                    if (p == item.ToString())
                    {
                        returnValue = true;
                    }
                }
            }
            else
            {
                returnValue = true;
            }

            return returnValue;
        }

        private bool CheckDate(string p)
        {
            Boolean returnValue = false;

            if (!checkBox1.Checked)
            {
                if (Convert.ToDateTime(p) >= dateTimePicker1.Value && Convert.ToDateTime(p) <= dateTimePicker2.Value)
                {
                    returnValue = true;
                }
            }
            else
            {
                returnValue = true;
            }

            return returnValue;
        }

        public DataTable GetDataTable(string filePath)
        {
            OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + Path.GetDirectoryName(filePath) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");
            conn.Open();
            string strQuery = "SELECT * FROM [" + Path.GetFileName(filePath) + "]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(strQuery, conn);
            DataSet ds = new System.Data.DataSet("CSV File");
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        class returnValues
        {
            public string p;
            public string q;
            public string o;

            public returnValues()
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessSATRecords();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialogSAT.ShowDialog();
            if (dr == DialogResult.OK)
            {
                WriteToCsvFile(updatedSAT, saveFileDialogSAT.FileName);
            }

            MessageBox.Show("File Saved!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkedListBox1.Enabled = false;
                //dateTimePicker2.Enabled = false;
            }
            else
            {
                checkedListBox1.Enabled = true;
                //dateTimePicker2.Enabled = true;
            }
        }
    }
}
