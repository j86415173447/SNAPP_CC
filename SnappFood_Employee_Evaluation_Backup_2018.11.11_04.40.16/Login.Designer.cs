﻿namespace SnappFood_Employee_Evaluation
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.forget = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.forget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.BackgroundImage = global::SnappFood_Employee_Evaluation.Properties.Resources.Check_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(264, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 62);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.BackgroundImage = global::SnappFood_Employee_Evaluation.Properties.Resources.Delete2_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(135, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 62);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.user.Location = new System.Drawing.Point(137, 124);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(250, 21);
            this.user.TabIndex = 2;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.pass.Location = new System.Drawing.Point(137, 193);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(250, 21);
            this.pass.TabIndex = 3;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // forget
            // 
            this.forget.BackColor = System.Drawing.Color.White;
            this.forget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forget.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.forget.ForeColor = System.Drawing.Color.Blue;
            this.forget.Location = new System.Drawing.Point(160, 296);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(203, 18);
            this.forget.TabIndex = 4;
            this.forget.Text = "رمز ورود خود را فراموش کرده اید؟";
            this.forget.ThemeName = "Office2010Silver";
            this.forget.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(642, 341);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private Telerik.WinControls.UI.RadLabel forget;
    }
}
