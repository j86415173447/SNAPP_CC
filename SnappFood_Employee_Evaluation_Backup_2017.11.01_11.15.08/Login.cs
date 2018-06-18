﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.OleDb;
using System.IO;

namespace SnappFood_Employee_Evaluation
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public string constr;
        private ErrorProvider errorProvider;
        public bool data_error = false;
        public Login()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
            errorProvider.RightToLeft = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.user.Select();
            //////////////////////////////////////////////////// Check .ini file
            string con_str_exist = File.Exists(Application.StartupPath + "\\CONSTR.ini").ToString();
            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\CONSTR.ini");
            constr = file.ReadLine();
            oleDbConnection1.ConnectionString = constr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            DataSet ds = new DataSet();
            OleDbDataAdapter adp2 = new OleDbDataAdapter();
            adp2.SelectCommand = new OleDbCommand();
            adp2.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand = "SELECT * FROM [SNAPP_CC_EVALUATION].[dbo].[Users] where [usr_name] = N'" + user.Text + "'";
            adp2.SelectCommand.CommandText = lcommand;
            adp2.Fill(ds);
            Int32 check = ds.Tables[0].Rows.Count;
            if (check == 0)
            {
                this.errorProvider.SetError(this.user, "نام کاربری وارد شده صحیح نیست.");
            }
            else
            {
                string currectpass = ds.Tables[0].Rows[0][2].ToString().Trim();
                if (currectpass == pass.Text)
                {
                    var mainfrm = new Main_Frm1();
                    mainfrm.constr = constr;
                    mainfrm.username = ds.Tables[0].Rows[0][3].ToString();
                    //DataSet ds3 = new DataSet();
                    //OleDbDataAdapter adp3 = new OleDbDataAdapter();
                    //adp3.SelectCommand = new OleDbCommand();
                    //adp3.SelectCommand.Connection = oleDbConnection1;
                    //oleDbCommand1.Parameters.Clear();
                    //string lcommand3 = "SELECT [User_ID],[User_Menu] FROM [SNAPP_CC_EVALUATION].[dbo].[Users_Access] where [User_ID] = N'" + user.Text + "'";
                    //adp3.SelectCommand.CommandText = lcommand3;
                    //adp3.Fill(ds3);
                    //Int32 check3 = ds3.Tables[0].Rows.Count;
                    //if (check3 != 0)
                    //{
                    //    for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                    //    {
                    //        //mainfrm.menuStrip1.Items.Find(ds3.Tables[0].Rows[i][1].ToString(), true)[0].Enabled = true;
                    //    }
                    //}
                    /////////////////////////////////////// load panel
                    //mainfrm.personel_id.Text = ds.Tables[0].Rows[0][0].ToString();
                    //DataTable dt222 = new DataTable();
                    //OleDbDataAdapter adp222 = new OleDbDataAdapter();
                    //adp222.SelectCommand = new OleDbCommand();
                    //adp222.SelectCommand.Connection = oleDbConnection1;
                    //oleDbCommand1.Parameters.Clear();
                    //string lcommand222 = "SELECT [Per_Pic],[per_f_name],[per_l_name] FROM [finance].[dbo].[PER_PERSONNEL_MASTER] where [Per_id] = '" + ds.Tables[0].Rows[0][0].ToString() + "'";
                    //adp2.SelectCommand.CommandText = lcommand222;
                    //adp2.Fill(dt222);
                    //if (dt222.Rows[0][0].ToString().Length != 0)
                    //{
                    //    byte[] imageData = (byte[])dt222.Rows[0][0];
                    //    Image newImage;
                    //    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    //    {
                    //        ms.Write(imageData, 0, imageData.Length);
                    //        newImage = Image.FromStream(ms, true);
                    //    }
                    //    //mainfrm.pictureBox1.Image = newImage;
                    //}
                    //else
                    //{
                    //    mainfrm.pictureBox1.Image = Properties.Resources.default_user;
                    //}
                    //mainfrm.per_f_name.Text = dt222.Rows[0][1].ToString();
                    //mainfrm.per_l_name.Text = dt222.Rows[0][2].ToString();
                    //mainfrm.per_role.Text = ds.Tables[0].Rows[0][4].ToString();
                    //mainfrm.username.Text = ds.Tables[0].Rows[0][3].ToString();
                    //mainfrm.user_role.Text = ds.Tables[0].Rows[0][4].ToString();
                    //mainfrm.per_id = ds.Tables[0].Rows[0][0].ToString();
                    this.Hide();
                    mainfrm.Show();
                }
                else
                {
                    this.errorProvider.SetError(this.pass, "کلمه عبور وارد شده صحیح نیست.");
                }
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(null, null);
            }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(null, null);
            }
        }
    }
}
