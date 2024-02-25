using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PR_01_02_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;
            DialogResult result = printdialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0,0));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
