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
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create an instance of FrmFileName and using a Show diaglog method
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            //Declaring a string variable to get the value of the text box
            string getInput = txtInput.Text;

            //Pasting a given code
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName())))
            {
                outputFile.WriteLine(getInput); Console.WriteLine(getInput);
            }

        }
    }
}
