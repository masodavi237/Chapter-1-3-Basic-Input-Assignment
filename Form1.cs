using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_3_Basic_Input_Assignment
{
    public partial class BasicInput : Form
    {

        public BasicInput()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void BasicInput_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;

        }

        private void tkbHeight_Scroll(object sender, EventArgs e)
        {
           
            lblReadOut.Text = ($"READOUT: {tkbHeight.Value}");
           
        }

        private void tkbHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblReadOut_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double userHeight = tkbHeight.Value;
            Console.WriteLine(userHeight);
            string name = txtName.Text;
            double age = Convert.ToDouble(nudAge.Value);
            double userHeightMeters = userHeight / 100;
            double yearsLeft = 80 - age;
            double heightFromTallest = 2.46 - userHeightMeters;

            lblMessage.Text = ("Please scroll down for your results!");

            lblAnswer.Text = ($"Thank you {name} for taking our in-depth survey! Albeit you are {age} years young, you are only {yearsLeft} " +
                $"from when science expects you to die! :) And what will you achieve? Tallest human? I don't think so, you are a" +
                $" whole {heightFromTallest} meters from that...");


            lblResults.Text = ("RESULTS");
             






        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }

   
    

}
