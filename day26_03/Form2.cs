using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day26_03
{
    public partial class Form2 : Form
    {
        string Form2_Message;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)Owner;
            Form2_Message = MainForm.Message;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Form2_Message, Font, Brushes.Black, 10, 10);
        }
    }
}
