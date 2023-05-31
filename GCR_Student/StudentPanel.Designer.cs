﻿
namespace GCR_Student
{
    partial class StudentPanel
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
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Datetime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MailSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(32, 223);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(124, 55);
            this.btn_Next.TabIndex = 26;
            this.btn_Next.Text = "< Previous";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Location = new System.Drawing.Point(296, 223);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(124, 55);
            this.btn_Previous.TabIndex = 25;
            this.btn_Previous.Text = "Next >";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Title.Location = new System.Drawing.Point(66, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(58, 28);
            this.lbl_Title.TabIndex = 19;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Description.Location = new System.Drawing.Point(17, 78);
            this.lbl_Description.MaximumSize = new System.Drawing.Size(290, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(80, 16);
            this.lbl_Description.TabIndex = 20;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Datetime
            // 
            this.lbl_Datetime.AutoSize = true;
            this.lbl_Datetime.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Datetime.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Datetime.Location = new System.Drawing.Point(276, 149);
            this.lbl_Datetime.Name = "lbl_Datetime";
            this.lbl_Datetime.Size = new System.Drawing.Size(44, 15);
            this.lbl_Datetime.TabIndex = 21;
            this.lbl_Datetime.Text = "date time";
            this.lbl_Datetime.Click += new System.EventHandler(this.lbl_Datetime_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(440, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 27;
            this.button1.Text = "Chat With Teacher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(440, 42);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(124, 55);
            this.btn_logout.TabIndex = 30;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(30)))), ((int)(((byte)(13)))));
            this.label5.Location = new System.Drawing.Point(27, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Recent Posts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Datetime);
            this.panel1.Controls.Add(this.lbl_Description);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 173);
            this.panel1.TabIndex = 32;
            // 
            // btn_MailSend
            // 
            this.btn_MailSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btn_MailSend.ForeColor = System.Drawing.Color.White;
            this.btn_MailSend.Location = new System.Drawing.Point(440, 101);
            this.btn_MailSend.Name = "btn_MailSend";
            this.btn_MailSend.Size = new System.Drawing.Size(124, 55);
            this.btn_MailSend.TabIndex = 33;
            this.btn_MailSend.Text = "Send Mail";
            this.btn_MailSend.UseVisualStyleBackColor = false;
            this.btn_MailSend.Click += new System.EventHandler(this.btn_MailSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Description:";
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(587, 309);
            this.Controls.Add(this.btn_MailSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Panel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Datetime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MailSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}