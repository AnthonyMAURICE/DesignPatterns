using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsShapes
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelTriFirst.Visible = true;
            textBoxOne.Visible = true;
            textBoxTwo.Visible = true;
            textBoxThree.Visible = false;
            labelTriSecond.Visible = true;
            labelTriSecond.Text = "Côté 2";
            labelTriTri.Visible = false;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelTriFirst.Visible = false;
            labelTriSecond.Visible = true;
            labelTriSecond.Text = "Côté";
            labelTriTri.Visible = false;
            textBoxOne.Visible = false;
            textBoxTwo.Visible = true;
            textBoxThree.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labelTriFirst.Visible = true;
            labelTriSecond.Visible = true;
            labelTriSecond.Text = "Côté 2";
            labelTriTri.Visible = false;
            textBoxOne.Visible = true;
            textBoxTwo.Visible = true;
            textBoxThree.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            labelTriFirst.Visible = true;
            labelTriSecond.Visible = true;
            labelTriSecond.Text = "Côté 2";
            labelTriTri.Visible = true;
            textBoxOne.Visible = true;
            textBoxTwo.Visible = true;
            textBoxThree.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
