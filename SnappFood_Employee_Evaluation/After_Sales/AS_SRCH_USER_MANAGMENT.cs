﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.OleDb;
using Telerik.WinControls.UI;

namespace SnappFood_Employee_Evaluation.After_Sales
{
    public partial class AS_SRCH_USER_MANAGMENT : Telerik.WinControls.UI.RadForm
    {
        After_Sales.AS_USER_MANAGMENT ob = null;
        public string constr;
        public List<string> conditions = new List<string>();
        public DataTable dt = new DataTable();

        public AS_SRCH_USER_MANAGMENT(After_Sales.AS_USER_MANAGMENT ob)
        {
            InitializeComponent();
            this.ob = ob;
            this.KeyPreview = true;
        }

        private void Search_Staff_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = constr;
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            conditions.Clear();
            if (Usr_ID.Text.Length != 0)
            {
                conditions.Add("[usr_name] like '%" + Usr_ID.Text + "%'");
            }
            //if (Per_Cd.Text.Length != 0)
            //{
            //    conditions.Add("[Chargoon_Id] like '%" + Per_Cd.Text + "%'");
            //}
            if (Per_Name.Text.Length != 0)
            {
                conditions.Add("[usr_per_name] like N'%" + Per_Name.Text + "%'");
            }
            //if (Doc_No.Text.Length != 0)
            //{
            //    conditions.Add("[Doc_No] like '%" + Doc_No.Text + "%'");
            //}
            OleDbDataAdapter adp1 = new OleDbDataAdapter();
            adp1.SelectCommand = new OleDbCommand();
            adp1.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand1;
            lcommand1 = "SELECT [usr_name] 'نام کاربری',[usr_per_name] 'نام و نام خانوادگی',[usr_role_nm] 'دسترسی',[usr_actv] 'کاربر فعال' " +
                        "FROM [SNAPP_CC_EVALUATION].[dbo].[Users] where [usr_role_cd] like 'AS%' ";
            if (conditions.Count != 0)
            {
                lcommand1 = lcommand1 + " AND " + string.Join(" AND ", conditions.ToArray());
            }
            adp1.SelectCommand.CommandText = lcommand1;
            dt.Clear();
            adp1.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                grid.DataSource = dt;
                grid.BestFitColumns(BestFitColumnMode.AllCells);
            }
            else
            {
                grid.DataSource = null;
            }
        }

        private void Search_Staff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Btn_Click(null, null);
            }
        }

        private void grid_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ob.usr_id.Text = grid.SelectedRows[0].Cells[0].Value.ToString();
            ob.searching();
            this.Close();
        }
    }
}
