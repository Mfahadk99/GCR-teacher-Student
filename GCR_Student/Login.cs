﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GCR_Student
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //check
            if (txt_Name.Text != "" && txt_Password.Text != "" && cmb_Login.Text != "")
            {
                if (cmb_Login.Text == "Teacher")
                {
                    if (!Regex.IsMatch(txt_Name.Text, @"^[a-zA-Z]+$"))
                    {
                        MessageBox.Show("User Name Can only contain Alphabets", "Invalid");
                        txt_Name.Text = "";
                        txt_Name.Focus();
                    }
                    else
                    {
                        Teachers t1 = new Teachers();
                        bool exist = t1.Find(txt_Name.Text, txt_Password.Text);
                        if (exist)
                        {
                            TeacherPanel tp = new TeacherPanel();
                            this.Hide();
                            tp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Name or password");
                        }
                    }
                }

                else
                {
                    if (!Regex.IsMatch(txt_Name.Text, @"^[a-zA-Z]+$"))
                    {
                        MessageBox.Show("User Name Can only contain Alphabets", "Invalid");
                        txt_Name.Text = "";
                        txt_Name.Focus();
                    }
                    else
                    {
                        Students s1 = new Students();
                        bool exist = s1.Find(txt_Name.Text, txt_Password.Text);
                        if (exist)
                        {
                            StudentPanel sp = new StudentPanel();
                            this.Hide();
                            sp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Name or password");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Provide All Details!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                count++;
                txt_Password.PasswordChar = '\0';
                btn_Show.Text = "Hide";
            }
            else
            {
                count++;
                txt_Password.PasswordChar = '*';
                btn_Show.Text = "Show";
            }
        }

        private void cmb_Login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
