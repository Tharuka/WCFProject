﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstituteService.TeacherServicesClient teacher = new InstituteService.TeacherServicesClient();
            MyChart chart = new MyChart(teacher.GetTeachersIncome());
            chart.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstituteService.EmployeeServicesClient client = new InstituteService.EmployeeServicesClient();   
            MyChart chart = new MyChart(client.GetEmployeePayment());
            chart.Show();
        }
    }
}
