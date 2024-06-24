using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fileToBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePathTextBox.Text))
            {
                return;
            }

            base64TextBox.Text = Convert.ToBase64String(File.ReadAllBytes(filePathTextBox.Text));
        }
    }
}
