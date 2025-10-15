using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streams_Lab_Ex_5_Reyes
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            // Calling a static variable to get the value of txtFileName
            String SetFileName = txtFileName.Text + "txt";
            //calling the close method
            Close();

        }
    }
}
