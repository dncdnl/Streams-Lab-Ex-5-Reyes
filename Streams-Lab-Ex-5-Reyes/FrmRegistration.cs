using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams_Lab_Ex_5_Reyes
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String[] list = new String[7];
            list[0] = "Student no.: " + txtStuNo.Text;
            list[1] = "Full Name: " + txtLastName.Text + "," + txtFn.Text + "," + txtMI.Text;
            list[2] = "Program: " + cbProgram.Text;
            list[3] = "Gender: " + cbGender.Text;
            list[4] = "Age: " + txtAge.Text;
            list[5] = "Birthday: " + dtpDate.Value.ToString("MM/dd/yyyy");
            list[6] = "Contact No.: " + txtContactNo.Text;
            string relativePath = @"../../Reyes, Danica , C. _LabStream";
            string docPath = Path.GetFullPath(relativePath);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, txtStuNo.Text + ".txt")))
            {
                foreach (string line in list)
                {
                    outputFile.WriteLine(line); 
                }
            }
        }
    }
}
