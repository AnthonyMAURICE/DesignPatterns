using ClassLibraryCompoVisit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = ClassLibraryCompoVisit.Rectangle;

namespace WinFormsShapes
{
    public partial class AddForm : Form
    {
        public event EventHandler ShapeAdded;
        Circle circle;
        Rectangle rectangle;
        Triangle triangle;
        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddCircle_Click(object sender, EventArgs e)
        {
            if (textBoxCircleAbsc.Text != string.Empty && textBoxCircOrdo.Text != string.Empty)
            {
                this.circle = new(int.Parse(textBoxCircleAbsc.Text), int.Parse(textBoxCircOrdo.Text), int.Parse(textBoxRadius.Text), int.Parse(textBoxRadius.Text));
                ShapeAdded?.Invoke(this.circle, new EventArgs());
            }
        }

        private void buttonAddRect_Click(object sender, EventArgs e)
        {
            if (textBoxRectAbs.Text != string.Empty && textBoxRectOrd.Text != string.Empty)
            {
                this.rectangle = new(int.Parse(textBoxRectAbs.Text), int.Parse(textBoxRectOrd.Text), int.Parse(textBoxRectWidth.Text), int.Parse(textBoxRectHeight.Text));
                ShapeAdded?.Invoke(this.rectangle, new EventArgs());
            }
        }

        private void buttonAddTriangle_Click(object sender, EventArgs e)
        {
            this.triangle = new(int.Parse(textTriAbs.Text), int.Parse(textTriOrd.Text), int.Parse(textTriWidth.Text), int.Parse(textTriHeight.Text));
            ShapeAdded?.Invoke(this.triangle, new EventArgs());
        }
    }
}
